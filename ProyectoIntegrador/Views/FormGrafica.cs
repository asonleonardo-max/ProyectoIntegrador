using OpenTK.Graphics.OpenGL4;
using ProyectoIntegrador.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoIntegrador.Views
{
    public partial class FormGrafica : Form
    {
        // ── Datos ──────────────────────────────────────────────────────────
        private List<Coordenada> coordenadas;

        // ── OpenGL ─────────────────────────────────────────────────────────
        private bool glListo = false;
        private int shaderProgram = 0;
        private int vaoMalla, vboMalla, iboMalla;
        private int vaoMallaLineas, vboMallaLineas;
        private int vaoPuntos, vboPuntos;
        private int vaoParedes, vboParedes;
        private int totalVertParedes = 0;
        private int vaoEjes, vboEjes;
        private int totalIndices = 0;
        private int totalPuntos = 0;
        private int totalVertEjes = 0;

        // ── Cámara ─────────────────────────────────────────────────────────
        private float rotX = 25f;
        private float rotY = -40f;
        private float zoom = 3.5f;
        private float panX = 0f;
        private float panY = 0f;
        private Point ultimoMouse;
        private bool mouseIzquierdoPresionado = false;
        private bool mouseDerechoPresionado = false;

        // ── Shaders ────────────────────────────────────────────────────────
        private const string VERT = @"#version 330 core
layout(location = 0) in vec3 aPos;
layout(location = 1) in vec3 aColor;
out vec3 vColor;
uniform mat4 uMVP;
void main(){
    gl_Position = uMVP * vec4(aPos, 1.0);
    gl_PointSize = 10.0;
    vColor = aColor;
}";
        private const string FRAG = @"#version 330 core
in vec3 vColor;
out vec4 FragColor;
void main(){
    FragColor = vec4(vColor, 1.0);
}";

        public FormGrafica(List<Coordenada> coordenadas)
        {
            this.coordenadas = coordenadas;
            InitializeComponent();

            glControl1.Load += GlLoad;
            glControl1.Paint += GlPaint;
            glControl1.Resize += GlResize;
            glControl1.MouseDown += GlMouseDown;
            glControl1.MouseUp += GlMouseUp;
            glControl1.MouseMove += GlMouseMove;
            glControl1.MouseWheel += GlMouseWheel;
            glControl1.DoubleClick += GlMouseDoubleClick; // ← aquí
            this.KeyPreview = true;
        }

        // ── Inicialización ─────────────────────────────────────────────────
        private void GlLoad(object sender, EventArgs e)
        {
            GL.ClearColor(0.08f, 0.08f, 0.14f, 1f);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.ProgramPointSize);

            shaderProgram = CrearShader(VERT, FRAG);
            glListo = true;

            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            ConstruirGeometria();
        }

        private void GlResize(object sender, EventArgs e)
        {
            if (!glListo) return;
            GL.Viewport(0, 0, glControl1.Width, glControl1.Height);
            glControl1.Invalidate();
        }

        // ── Render ─────────────────────────────────────────────────────────
        private void GlPaint(object sender, PaintEventArgs e)
        {
            if (!glListo) return;

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.UseProgram(shaderProgram);

            var mvp = ObtenerMVP();
            int loc = GL.GetUniformLocation(shaderProgram, "uMVP");
            GL.UniformMatrix4(loc, false, ref mvp);

            // Ejes y plano base
            if (totalVertEjes > 0)
            {
                GL.LineWidth(2f);
                GL.BindVertexArray(vaoEjes);
                GL.DrawArrays(PrimitiveType.Lines, 0, totalVertEjes);
            }

            // Paredes laterales
            if (totalVertParedes > 0)
            {
                GL.BindVertexArray(vaoParedes);
                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
                GL.DrawArrays(PrimitiveType.Triangles, 0, totalVertParedes);
            }

            // Terreno
            if (totalIndices > 0)
            {
                // 1. Superficie sólida con colores
                GL.BindVertexArray(vaoMalla);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, iboMalla);
                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
                GL.Enable(EnableCap.PolygonOffsetFill);
                GL.PolygonOffset(2f, 2f);
                GL.DrawElements(PrimitiveType.Triangles, totalIndices, DrawElementsType.UnsignedInt, 0);
                GL.Disable(EnableCap.PolygonOffsetFill);

                // 2. Líneas negras encima usando el VAO de líneas
                GL.BindVertexArray(vaoMallaLineas);
                GL.BindBuffer(BufferTarget.ElementArrayBuffer, iboMalla);
                GL.LineWidth(1f);
                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
                GL.DrawElements(PrimitiveType.Triangles, totalIndices, DrawElementsType.UnsignedInt, 0);

                GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            }

            // Puntos blancos
            if (totalPuntos > 0)
            {
                GL.BindVertexArray(vaoPuntos);
                GL.DrawArrays(PrimitiveType.Points, 0, totalPuntos);
            }

            GL.BindVertexArray(0);
            glControl1.SwapBuffers();

            // Etiquetas encima del GLControl
            DibujarEtiquetas();
        }

        // ── Etiquetas X Y Z con GDI+ ───────────────────────────────────────
        private void DibujarEtiquetas()
        {
            using (Graphics g = glControl1.CreateGraphics())
            {
                Font f = new Font("Arial", 12, FontStyle.Bold);

                // Etiqueta X — rojo
                g.DrawString("X", f, Brushes.Red,
                    glControl1.Width / 2 + 160, glControl1.Height / 2 + 10);

                // Etiqueta Z (altura) — azul
                g.DrawString("Z (Altura)", f, Brushes.CornflowerBlue,
                    glControl1.Width / 2 - 30, 15);

                // Etiqueta Y — verde
                g.DrawString("Y", f, Brushes.LimeGreen,
                    glControl1.Width / 2 + 10, glControl1.Height / 2 + 130);

                // Instrucciones
                Font fSmall = new Font("Arial", 9);
                g.DrawString("🖱 Izquierdo: Rotar  |  Derecho: Mover  |  Rueda: Zoom  |  Doble clic: Resetear",
                    fSmall, Brushes.LightGray, 10, glControl1.Height - 25);

                f.Dispose();
                fSmall.Dispose();
            }
        }

        // ── Geometría ──────────────────────────────────────────────────────
        private void ConstruirGeometria()
        {
            if (coordenadas == null || coordenadas.Count < 3) return;

            double xMin = coordenadas.Min(c => c.X), xMax = coordenadas.Max(c => c.X);
            double yMin = coordenadas.Min(c => c.Y), yMax = coordenadas.Max(c => c.Y);
            double zMin = coordenadas.Min(c => c.Z), zMax = coordenadas.Max(c => c.Z);

            double rX = xMax - xMin; if (rX == 0) rX = 1;
            double rY = yMax - yMin; if (rY == 0) rY = 1;
            double rZ = zMax - zMin; if (rZ == 0) rZ = 1;

            int div = 30;
            int cols = div + 1;
            float[] vertMalla = new float[cols * cols * 6];

            for (int j = 0; j <= div; j++)
            {
                for (int i = 0; i <= div; i++)
                {
                    double wx = xMin + i * (rX / div);
                    double wy = yMin + j * (rY / div);
                    double wz = InterpolarAltura(wx, wy);

                    float nx = (float)((wx - xMin) / rX) - 0.5f;
                    float ny = (float)((wy - yMin) / rY) - 0.5f;
                    float nz = (float)((wz - zMin) / rZ) * 0.8f;

                    var (r, g, b) = ColorAltura(nz / 0.8f);
                    int idx = (j * cols + i) * 6;
                    vertMalla[idx] = nx;
                    vertMalla[idx + 1] = nz;
                    vertMalla[idx + 2] = ny;
                    vertMalla[idx + 3] = r;
                    vertMalla[idx + 4] = g;
                    vertMalla[idx + 5] = b;
                }
            }

            List<uint> indices = new List<uint>();
            for (int j = 0; j < div; j++)
                for (int i = 0; i < div; i++)
                {
                    uint tl = (uint)(j * cols + i);
                    uint tr = tl + 1;
                    uint bl = (uint)((j + 1) * cols + i);
                    uint br = bl + 1;
                    indices.Add(tl); indices.Add(bl); indices.Add(tr);
                    indices.Add(tr); indices.Add(bl); indices.Add(br);
                }
            totalIndices = indices.Count;

            SubirVAO(ref vaoMalla, ref vboMalla, vertMalla);
            iboMalla = GL.GenBuffer();
            GL.BindVertexArray(vaoMalla);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, iboMalla);
            GL.BufferData(BufferTarget.ElementArrayBuffer,
                          indices.Count * sizeof(uint), indices.ToArray(),
                          BufferUsageHint.StaticDraw);
            GL.BindVertexArray(0);

            // ── VAO para líneas negras encima ──────────────────────────────────
            float[] vertLineas = new float[vertMalla.Length];
            Array.Copy(vertMalla, vertLineas, vertMalla.Length);
            for (int i = 0; i < cols * cols; i++)
            {
                vertLineas[i * 6 + 3] = 0f;
                vertLineas[i * 6 + 4] = 0f;
                vertLineas[i * 6 + 5] = 0f;
            }
            SubirVAO(ref vaoMallaLineas, ref vboMallaLineas, vertLineas);
            GL.BindVertexArray(vaoMallaLineas);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, iboMalla);
            GL.BindVertexArray(0);

            // ── Paredes laterales ──────────────────────────────────────────────
            float pr = 0.45f, pg = 0.30f, pb = 0.15f;
            List<float> paredes = new List<float>();

            Action<int, int, int, int> agregarPared = (j0, i0, j1, i1) =>
            {
                int idx0 = (j0 * cols + i0) * 6;
                int idx1 = (j1 * cols + i1) * 6;
                float x0 = vertMalla[idx0], y0 = vertMalla[idx0 + 1], z0 = vertMalla[idx0 + 2];
                float x1 = vertMalla[idx1], y1 = vertMalla[idx1 + 1], z1 = vertMalla[idx1 + 2];
                paredes.AddRange(new[] { x0, y0, z0, pr, pg, pb });
                paredes.AddRange(new[] { x0, 0f, z0, pr * 0.6f, pg * 0.6f, pb * 0.6f });
                paredes.AddRange(new[] { x1, y1, z1, pr, pg, pb });
                paredes.AddRange(new[] { x1, y1, z1, pr, pg, pb });
                paredes.AddRange(new[] { x0, 0f, z0, pr * 0.6f, pg * 0.6f, pb * 0.6f });
                paredes.AddRange(new[] { x1, 0f, z1, pr * 0.6f, pg * 0.6f, pb * 0.6f });
            };

            for (int i = 0; i < div; i++) agregarPared(0, i + 1, 0, i); // frente
            for (int i = 0; i < div; i++) agregarPared(div, i, div, i + 1); // atrás
            for (int j = 0; j < div; j++) agregarPared(j, 0, j + 1, 0); // izquierda
            for (int j = 0; j < div; j++) agregarPared(j + 1, div, j, div); // derecha

            float[] vertParedes = paredes.ToArray();
            totalVertParedes = vertParedes.Length / 6;
            SubirVAOSimple(ref vaoParedes, ref vboParedes, vertParedes);

            // Puntos originales
            float[] vertPuntos = new float[coordenadas.Count * 6];
            for (int i = 0; i < coordenadas.Count; i++)
            {
                var c = coordenadas[i];
                float nx = (float)((c.X - xMin) / rX) - 0.5f;
                float ny = (float)((c.Y - yMin) / rY) - 0.5f;
                float nz = (float)((c.Z - zMin) / rZ) * 0.8f;
                int idx = i * 6;
                vertPuntos[idx] = nx;
                vertPuntos[idx + 1] = nz;
                vertPuntos[idx + 2] = ny;
                vertPuntos[idx + 3] = 1f;
                vertPuntos[idx + 4] = 1f;
                vertPuntos[idx + 5] = 1f;
            }
            totalPuntos = coordenadas.Count;
            SubirVAO(ref vaoPuntos, ref vboPuntos, vertPuntos);

            // Ejes + plano base
            float[] vertEjes =
            {
                // Eje X — rojo
                -0.6f, 0f,  0f,    0.9f, 0.2f, 0.2f,
                 0.7f, 0f,  0f,    0.9f, 0.2f, 0.2f,
                // Eje Z altura — azul
                 0f,   0f,  0f,    0.3f, 0.5f, 1.0f,
                 0f,   1.0f,0f,    0.3f, 0.5f, 1.0f,
                // Eje Y — verde
                 0f,   0f, -0.6f,  0.2f, 0.9f, 0.2f,
                 0f,   0f,  0.7f,  0.2f, 0.9f, 0.2f,
                // Plano base — gris
                -0.5f, 0f, -0.5f,  0.25f, 0.25f, 0.25f,
                 0.5f, 0f, -0.5f,  0.25f, 0.25f, 0.25f,
                 0.5f, 0f, -0.5f,  0.25f, 0.25f, 0.25f,
                 0.5f, 0f,  0.5f,  0.25f, 0.25f, 0.25f,
                 0.5f, 0f,  0.5f,  0.25f, 0.25f, 0.25f,
                -0.5f, 0f,  0.5f,  0.25f, 0.25f, 0.25f,
                -0.5f, 0f,  0.5f,  0.25f, 0.25f, 0.25f,
                -0.5f, 0f, -0.5f,  0.25f, 0.25f, 0.25f,
                // Líneas internas del plano
                -0.5f, 0f,  0f,    0.2f, 0.2f, 0.2f,
                 0.5f, 0f,  0f,    0.2f, 0.2f, 0.2f,
                 0f,   0f, -0.5f,  0.2f, 0.2f, 0.2f,
                 0f,   0f,  0.5f,  0.2f, 0.2f, 0.2f,
            };
            totalVertEjes = 22;
            SubirVAO(ref vaoEjes, ref vboEjes, vertEjes);
        }

        // ── Helpers ────────────────────────────────────────────────────────
        private void SubirVAO(ref int vao, ref int vbo, float[] data)
        {
            if (vao != 0) GL.DeleteVertexArray(vao);
            if (vbo != 0) GL.DeleteBuffer(vbo);

            vao = GL.GenVertexArray();
            vbo = GL.GenBuffer();

            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer,
                          data.Length * sizeof(float), data,
                          BufferUsageHint.StaticDraw);

            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float,
                                   false, 6 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float,
                                   false, 6 * sizeof(float), 3 * sizeof(float));
            GL.EnableVertexAttribArray(1);
            GL.BindVertexArray(0);
        }

        private void SubirVAOSimple(ref int vao, ref int vbo, float[] data)
        {
            if (vao != 0) GL.DeleteVertexArray(vao);
            if (vbo != 0) GL.DeleteBuffer(vbo);
            vao = GL.GenVertexArray();
            vbo = GL.GenBuffer();
            GL.BindVertexArray(vao);
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, data.Length * sizeof(float), data, BufferUsageHint.StaticDraw);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);
            GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 6 * sizeof(float), 3 * sizeof(float));
            GL.EnableVertexAttribArray(1);
            GL.BindVertexArray(0);
        }

        private OpenTK.Mathematics.Matrix4 ObtenerMVP()
        {
            float aspect = glControl1.Width > 0 && glControl1.Height > 0
                ? (float)glControl1.Width / glControl1.Height : 1f;

            var proj = OpenTK.Mathematics.Matrix4.CreatePerspectiveFieldOfView(
                           OpenTK.Mathematics.MathHelper.DegreesToRadians(45f),
                           aspect, 0.1f, 100f);

            var view = OpenTK.Mathematics.Matrix4.CreateTranslation(panX, panY, -zoom);

            var rXMat = OpenTK.Mathematics.Matrix4.CreateRotationX(
                            OpenTK.Mathematics.MathHelper.DegreesToRadians(rotX));
            var rYMat = OpenTK.Mathematics.Matrix4.CreateRotationY(
                            OpenTK.Mathematics.MathHelper.DegreesToRadians(rotY));

            return rXMat * rYMat * view * proj;
        }

        private int CrearShader(string vert, string frag)
        {
            int v = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(v, vert);
            GL.CompileShader(v);

            int f = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(f, frag);
            GL.CompileShader(f);

            int p = GL.CreateProgram();
            GL.AttachShader(p, v);
            GL.AttachShader(p, f);
            GL.LinkProgram(p);
            GL.DeleteShader(v);
            GL.DeleteShader(f);
            return p;
        }

        private double InterpolarAltura(double x, double y)
        {
            double sumP = 0, sumH = 0;
            foreach (var p in coordenadas)
            {
                double d = Math.Sqrt(Math.Pow(p.X - x, 2) + Math.Pow(p.Y - y, 2));
                if (d < 0.0001) return p.Z;
                double w = 1.0 / (d * d);
                sumP += w;
                sumH += w * p.Z;
            }
            return sumH / sumP;
        }

        private (float r, float g, float b) ColorAltura(float t)
        {
            if (t < 0.25f) { float s = t / 0.25f; return (0f, s, 1f - s); }
            if (t < 0.50f) { return (0f, 1f, 0f); }
            if (t < 0.75f) { float s = (t - 0.5f) / 0.25f; return (s, 1f, 0f); }
            else { float s = (t - 0.75f) / 0.25f; return (1f, 1f - s, 0f); }
        }

        // ── Mouse mejorado ─────────────────────────────────────────────────
        private void GlMouseDown(object sender, MouseEventArgs e)
        {
            ultimoMouse = e.Location;
            if (e.Button == MouseButtons.Left) mouseIzquierdoPresionado = true;
            if (e.Button == MouseButtons.Right) mouseDerechoPresionado = true;
        }

        private void GlMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) mouseIzquierdoPresionado = false;
            if (e.Button == MouseButtons.Right) mouseDerechoPresionado = false;
        }

        private void GlMouseMove(object sender, MouseEventArgs e)
        {
            float dx = (e.X - ultimoMouse.X);
            float dy = (e.Y - ultimoMouse.Y);

            if (mouseIzquierdoPresionado)
            {
                // Rotar con clic izquierdo
                rotY += dx * 0.4f;
                rotX += dy * 0.4f;
                rotX = Math.Clamp(rotX, -89f, 89f);
            }

            if (mouseDerechoPresionado)
            {
                // Mover con clic derecho
                panX += dx * 0.003f;
                panY -= dy * 0.003f;
            }

            ultimoMouse = e.Location;
            glControl1.Invalidate();
        }

        private void GlMouseWheel(object sender, MouseEventArgs e)
        {
            // Zoom más suave
            zoom = Math.Clamp(zoom - e.Delta * 0.002f, 1f, 12f);
            glControl1.Invalidate();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            // Doble clic o tecla R para resetear la vista
            if (e.KeyCode == Keys.R)
            {
                rotX = 25f; rotY = -40f;
                zoom = 3.5f; panX = 0f; panY = 0f;
                glControl1.Invalidate();
            }
        }

        private void GlMouseDoubleClick(object sender, EventArgs e)
        {
            rotX = 25f; rotY = -40f;
            zoom = 3.5f; panX = 0f; panY = 0f;
            glControl1.Invalidate();
        }
    }
}