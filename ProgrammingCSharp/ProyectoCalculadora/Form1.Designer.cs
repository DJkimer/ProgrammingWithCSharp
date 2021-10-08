
namespace ProyectoCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultado
            // 
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultado.Location = new System.Drawing.Point(18, 30);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(314, 33);
            this.resultado.TabIndex = 0;
            this.resultado.Text = "0";
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(98, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(178, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(258, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 140);
            this.button4.TabIndex = 4;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ActualizarOperador);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(178, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 67);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(98, 231);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 67);
            this.button7.TabIndex = 6;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(18, 231);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 67);
            this.button8.TabIndex = 5;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(258, 304);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 140);
            this.button9.TabIndex = 12;
            this.button9.Text = "=";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.CalcularResultado);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(178, 304);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 67);
            this.button10.TabIndex = 11;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(98, 304);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(74, 67);
            this.button11.TabIndex = 10;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // numero1
            // 
            this.numero1.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.Location = new System.Drawing.Point(18, 304);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(74, 67);
            this.numero1.TabIndex = 9;
            this.numero1.Text = "1";
            this.numero1.UseVisualStyleBackColor = true;
            this.numero1.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(18, 377);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(154, 67);
            this.button15.TabIndex = 14;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ActualizarOperando);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(258, 85);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(74, 67);
            this.button16.TabIndex = 20;
            this.button16.Text = "-";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ActualizarOperador);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(178, 85);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(74, 67);
            this.button17.TabIndex = 19;
            this.button17.Text = "*";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.ActualizarOperador);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(98, 85);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(74, 67);
            this.button18.TabIndex = 18;
            this.button18.Text = "/";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.ActualizarOperador);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(178, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 67);
            this.button5.TabIndex = 21;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Rockwell Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(18, 85);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(74, 67);
            this.button13.TabIndex = 22;
            this.button13.Text = "CE";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.LimpiarTodo);
            // 
            // txtOperador
            // 
            this.txtOperador.Location = new System.Drawing.Point(338, 30);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.ReadOnly = true;
            this.txtOperador.Size = new System.Drawing.Size(30, 20);
            this.txtOperador.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 476);
            this.Controls.Add(this.txtOperador);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button numero1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txtOperador;
    }
}

