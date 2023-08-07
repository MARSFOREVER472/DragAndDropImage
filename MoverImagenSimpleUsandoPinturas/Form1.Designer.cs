namespace MoverImagenSimpleUsandoPinturas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            InterfazTemporizador = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(484, 38);
            label1.TabIndex = 0;
            label1.Text = "Arrastrando o soltando una imagen";
            // 
            // InterfazTemporizador
            // 
            InterfazTemporizador.Enabled = true;
            InterfazTemporizador.Interval = 20;
            InterfazTemporizador.Tick += FormTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            ShowIcon = false;
            Text = "Mover una imagen simple";
            Paint += FormPaintEvent;
            MouseDown += FormMouseDown;
            MouseMove += FormMouseMove;
            MouseUp += FormMouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer InterfazTemporizador;
    }
}