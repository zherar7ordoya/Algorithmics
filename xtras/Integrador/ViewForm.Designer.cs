﻿namespace Integrador
{
    partial class ViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            panel1 = new Panel();
            ApellidoTextBox = new TextBox();
            NombreTextBox = new TextBox();
            DniTextBox = new TextBox();
            IdPersonaTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ValorTotalAutosLabel = new Label();
            AutosDePersonaDataGridView = new DataGridView();
            EliminarPersonaButton = new Button();
            GuardarPersonaButton = new Button();
            NuevoPersonaButton = new Button();
            PersonasDataGridView = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            AñoTextBox = new TextBox();
            label14 = new Label();
            label11 = new Label();
            PrecioNumericUpDown = new NumericUpDown();
            ModeloTextBox = new TextBox();
            MarcaTextBox = new TextBox();
            PatenteTextBox = new TextBox();
            IdAutoTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            EliminarAutoButton = new Button();
            GuardarAutoButton = new Button();
            NuevoAutoButton = new Button();
            AutosDisponiblesDataGridView = new DataGridView();
            label12 = new Label();
            AsignarAutoButton = new Button();
            QuitarAutoButton = new Button();
            AutosAsignadosDataGridView = new DataGridView();
            label13 = new Label();
            ErrorProvider = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AutosDePersonaDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersonasDataGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrecioNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AutosDisponiblesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AutosAsignadosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ApellidoTextBox);
            panel1.Controls.Add(NombreTextBox);
            panel1.Controls.Add(DniTextBox);
            panel1.Controls.Add(IdPersonaTextBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ValorTotalAutosLabel);
            panel1.Controls.Add(AutosDePersonaDataGridView);
            panel1.Controls.Add(EliminarPersonaButton);
            panel1.Controls.Add(GuardarPersonaButton);
            panel1.Controls.Add(NuevoPersonaButton);
            panel1.Controls.Add(PersonasDataGridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(549, 490);
            panel1.TabIndex = 0;
            // 
            // ApellidoTextBox
            // 
            ApellidoTextBox.Location = new Point(433, 376);
            ApellidoTextBox.Name = "ApellidoTextBox";
            ApellidoTextBox.Size = new Size(100, 25);
            ApellidoTextBox.TabIndex = 14;
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(433, 345);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(100, 25);
            NombreTextBox.TabIndex = 13;
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(433, 314);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(100, 25);
            DniTextBox.TabIndex = 12;
            // 
            // IdPersonaTextBox
            // 
            IdPersonaTextBox.Location = new Point(433, 283);
            IdPersonaTextBox.Name = "IdPersonaTextBox";
            IdPersonaTextBox.ReadOnly = true;
            IdPersonaTextBox.Size = new Size(100, 25);
            IdPersonaTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(329, 383);
            label6.Name = "label6";
            label6.Size = new Size(61, 18);
            label6.TabIndex = 10;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 352);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 9;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(329, 321);
            label4.Name = "label4";
            label4.Size = new Size(31, 18);
            label4.TabIndex = 8;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 290);
            label3.Name = "label3";
            label3.Size = new Size(20, 18);
            label3.TabIndex = 7;
            label3.Text = "Id";
            // 
            // ValorTotalAutosLabel
            // 
            ValorTotalAutosLabel.AutoSize = true;
            ValorTotalAutosLabel.Font = new Font("Calibri", 22F);
            ValorTotalAutosLabel.Location = new Point(467, 213);
            ValorTotalAutosLabel.Name = "ValorTotalAutosLabel";
            ValorTotalAutosLabel.Size = new Size(76, 37);
            ValorTotalAutosLabel.TabIndex = 6;
            ValorTotalAutosLabel.Text = "Total";
            // 
            // AutosDePersonaDataGridView
            // 
            AutosDePersonaDataGridView.AllowUserToAddRows = false;
            AutosDePersonaDataGridView.AllowUserToDeleteRows = false;
            AutosDePersonaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AutosDePersonaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AutosDePersonaDataGridView.Location = new Point(319, 50);
            AutosDePersonaDataGridView.Name = "AutosDePersonaDataGridView";
            AutosDePersonaDataGridView.ReadOnly = true;
            AutosDePersonaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutosDePersonaDataGridView.Size = new Size(214, 150);
            AutosDePersonaDataGridView.TabIndex = 5;
            // 
            // EliminarPersonaButton
            // 
            EliminarPersonaButton.AutoSize = true;
            EliminarPersonaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EliminarPersonaButton.Location = new Point(464, 445);
            EliminarPersonaButton.Name = "EliminarPersonaButton";
            EliminarPersonaButton.Size = new Size(69, 28);
            EliminarPersonaButton.TabIndex = 4;
            EliminarPersonaButton.Text = "Eliminar";
            EliminarPersonaButton.UseVisualStyleBackColor = true;
            EliminarPersonaButton.Click += EliminarPersonaButton_Click;
            // 
            // GuardarPersonaButton
            // 
            GuardarPersonaButton.AutoSize = true;
            GuardarPersonaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GuardarPersonaButton.Location = new Point(391, 445);
            GuardarPersonaButton.Name = "GuardarPersonaButton";
            GuardarPersonaButton.Size = new Size(67, 28);
            GuardarPersonaButton.TabIndex = 3;
            GuardarPersonaButton.Text = "Guardar";
            GuardarPersonaButton.UseVisualStyleBackColor = true;
            GuardarPersonaButton.Click += GuardarPersonaButton_Click;
            // 
            // NuevoPersonaButton
            // 
            NuevoPersonaButton.AutoSize = true;
            NuevoPersonaButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NuevoPersonaButton.Location = new Point(319, 445);
            NuevoPersonaButton.Name = "NuevoPersonaButton";
            NuevoPersonaButton.Size = new Size(59, 28);
            NuevoPersonaButton.TabIndex = 2;
            NuevoPersonaButton.Text = "Nuevo";
            NuevoPersonaButton.UseVisualStyleBackColor = true;
            NuevoPersonaButton.Click += NuevoPersonaButton_Click;
            // 
            // PersonasDataGridView
            // 
            PersonasDataGridView.AllowUserToAddRows = false;
            PersonasDataGridView.AllowUserToDeleteRows = false;
            PersonasDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            PersonasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonasDataGridView.Location = new Point(13, 50);
            PersonasDataGridView.Name = "PersonasDataGridView";
            PersonasDataGridView.ReadOnly = true;
            PersonasDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PersonasDataGridView.Size = new Size(300, 423);
            PersonasDataGridView.TabIndex = 1;
            PersonasDataGridView.SelectionChanged += PersonasDataGridView_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 22F);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 0;
            label1.Text = "Personas";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(AñoTextBox);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(PrecioNumericUpDown);
            panel2.Controls.Add(ModeloTextBox);
            panel2.Controls.Add(MarcaTextBox);
            panel2.Controls.Add(PatenteTextBox);
            panel2.Controls.Add(IdAutoTextBox);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(EliminarAutoButton);
            panel2.Controls.Add(GuardarAutoButton);
            panel2.Controls.Add(NuevoAutoButton);
            panel2.Controls.Add(AutosDisponiblesDataGridView);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(691, 12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(549, 490);
            panel2.TabIndex = 1;
            // 
            // AñoTextBox
            // 
            AñoTextBox.Location = new Point(433, 174);
            AñoTextBox.Name = "AñoTextBox";
            AñoTextBox.Size = new Size(100, 25);
            AñoTextBox.TabIndex = 18;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(319, 177);
            label14.Name = "label14";
            label14.Size = new Size(33, 18);
            label14.TabIndex = 17;
            label14.Text = "Año";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(319, 207);
            label11.Name = "label11";
            label11.Size = new Size(47, 18);
            label11.TabIndex = 16;
            label11.Text = "Precio";
            // 
            // PrecioNumericUpDown
            // 
            PrecioNumericUpDown.DecimalPlaces = 2;
            PrecioNumericUpDown.Location = new Point(433, 205);
            PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            PrecioNumericUpDown.Size = new Size(100, 25);
            PrecioNumericUpDown.TabIndex = 15;
            // 
            // ModeloTextBox
            // 
            ModeloTextBox.Location = new Point(433, 143);
            ModeloTextBox.Name = "ModeloTextBox";
            ModeloTextBox.Size = new Size(100, 25);
            ModeloTextBox.TabIndex = 14;
            // 
            // MarcaTextBox
            // 
            MarcaTextBox.Location = new Point(433, 112);
            MarcaTextBox.Name = "MarcaTextBox";
            MarcaTextBox.Size = new Size(100, 25);
            MarcaTextBox.TabIndex = 13;
            // 
            // PatenteTextBox
            // 
            PatenteTextBox.Location = new Point(433, 81);
            PatenteTextBox.Name = "PatenteTextBox";
            PatenteTextBox.Size = new Size(100, 25);
            PatenteTextBox.TabIndex = 12;
            // 
            // IdAutoTextBox
            // 
            IdAutoTextBox.Location = new Point(433, 50);
            IdAutoTextBox.Name = "IdAutoTextBox";
            IdAutoTextBox.ReadOnly = true;
            IdAutoTextBox.Size = new Size(100, 25);
            IdAutoTextBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(319, 146);
            label7.Name = "label7";
            label7.Size = new Size(56, 18);
            label7.TabIndex = 10;
            label7.Text = "Modelo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(319, 115);
            label8.Name = "label8";
            label8.Size = new Size(45, 18);
            label8.TabIndex = 9;
            label8.Text = "Marca";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(319, 84);
            label9.Name = "label9";
            label9.Size = new Size(57, 18);
            label9.TabIndex = 8;
            label9.Text = "Patente";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(319, 53);
            label10.Name = "label10";
            label10.Size = new Size(20, 18);
            label10.TabIndex = 7;
            label10.Text = "Id";
            // 
            // EliminarAutoButton
            // 
            EliminarAutoButton.AutoSize = true;
            EliminarAutoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EliminarAutoButton.Location = new Point(464, 445);
            EliminarAutoButton.Name = "EliminarAutoButton";
            EliminarAutoButton.Size = new Size(69, 28);
            EliminarAutoButton.TabIndex = 4;
            EliminarAutoButton.Text = "Eliminar";
            EliminarAutoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarAutoButton
            // 
            GuardarAutoButton.AutoSize = true;
            GuardarAutoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GuardarAutoButton.Location = new Point(391, 445);
            GuardarAutoButton.Name = "GuardarAutoButton";
            GuardarAutoButton.Size = new Size(67, 28);
            GuardarAutoButton.TabIndex = 3;
            GuardarAutoButton.Text = "Guardar";
            GuardarAutoButton.UseVisualStyleBackColor = true;
            // 
            // NuevoAutoButton
            // 
            NuevoAutoButton.AutoSize = true;
            NuevoAutoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NuevoAutoButton.Location = new Point(319, 445);
            NuevoAutoButton.Name = "NuevoAutoButton";
            NuevoAutoButton.Size = new Size(59, 28);
            NuevoAutoButton.TabIndex = 2;
            NuevoAutoButton.Text = "Nuevo";
            NuevoAutoButton.UseVisualStyleBackColor = true;
            // 
            // AutosDisponiblesDataGridView
            // 
            AutosDisponiblesDataGridView.AllowUserToAddRows = false;
            AutosDisponiblesDataGridView.AllowUserToDeleteRows = false;
            AutosDisponiblesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AutosDisponiblesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AutosDisponiblesDataGridView.Location = new Point(13, 50);
            AutosDisponiblesDataGridView.Name = "AutosDisponiblesDataGridView";
            AutosDisponiblesDataGridView.ReadOnly = true;
            AutosDisponiblesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutosDisponiblesDataGridView.Size = new Size(300, 423);
            AutosDisponiblesDataGridView.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 22F);
            label12.Location = new Point(13, 10);
            label12.Name = "label12";
            label12.Size = new Size(235, 37);
            label12.TabIndex = 0;
            label12.Text = "Autos disponibles";
            // 
            // AsignarAutoButton
            // 
            AsignarAutoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AsignarAutoButton.Image = Properties.Resources.sign_left;
            AsignarAutoButton.Location = new Point(567, 63);
            AsignarAutoButton.Name = "AsignarAutoButton";
            AsignarAutoButton.Size = new Size(118, 34);
            AsignarAutoButton.TabIndex = 15;
            AsignarAutoButton.Text = "Asignar auto";
            AsignarAutoButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            AsignarAutoButton.UseVisualStyleBackColor = true;
            // 
            // QuitarAutoButton
            // 
            QuitarAutoButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            QuitarAutoButton.Image = (Image)resources.GetObject("QuitarAutoButton.Image");
            QuitarAutoButton.Location = new Point(567, 179);
            QuitarAutoButton.Name = "QuitarAutoButton";
            QuitarAutoButton.Size = new Size(118, 34);
            QuitarAutoButton.TabIndex = 16;
            QuitarAutoButton.Text = "Quitar auto";
            QuitarAutoButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            QuitarAutoButton.UseVisualStyleBackColor = true;
            // 
            // AutosAsignadosDataGridView
            // 
            AutosAsignadosDataGridView.AllowUserToAddRows = false;
            AutosAsignadosDataGridView.AllowUserToDeleteRows = false;
            AutosAsignadosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            AutosAsignadosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AutosAsignadosDataGridView.Location = new Point(332, 508);
            AutosAsignadosDataGridView.Name = "AutosAsignadosDataGridView";
            AutosAsignadosDataGridView.ReadOnly = true;
            AutosAsignadosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutosAsignadosDataGridView.Size = new Size(673, 150);
            AutosAsignadosDataGridView.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 22F);
            label13.Location = new Point(12, 564);
            label13.Name = "label13";
            label13.Size = new Size(216, 37);
            label13.TabIndex = 18;
            label13.Text = "Autos asignados";
            // 
            // ErrorProvider
            // 
            ErrorProvider.ContainerControl = this;
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1250, 668);
            Controls.Add(label13);
            Controls.Add(AutosAsignadosDataGridView);
            Controls.Add(QuitarAutoButton);
            Controls.Add(AsignarAutoButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 11F);
            Margin = new Padding(4);
            Name = "ViewForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Integrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AutosDePersonaDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersonasDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PrecioNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AutosDisponiblesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AutosAsignadosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Panel panel1;
        internal Label label1;
        internal DataGridView PersonasDataGridView;
        internal Button EliminarPersonaButton;
        internal Button GuardarPersonaButton;
        internal Button NuevoPersonaButton;
        internal DataGridView AutosDePersonaDataGridView;
        internal Label ValorTotalAutosLabel;
        internal Label label6;
        internal Label label5;
        internal Label label4;
        internal Label label3;
        internal TextBox ApellidoTextBox;
        internal TextBox NombreTextBox;
        internal TextBox DniTextBox;
        internal TextBox IdPersonaTextBox;
        internal Panel panel2;
        internal TextBox ModeloTextBox;
        internal TextBox MarcaTextBox;
        internal TextBox PatenteTextBox;
        internal TextBox IdAutoTextBox;
        internal Label label7;
        internal Label label8;
        internal Label label9;
        internal Label label10;
        internal Button EliminarAutoButton;
        internal Button GuardarAutoButton;
        internal Button NuevoAutoButton;
        internal DataGridView AutosDisponiblesDataGridView;
        internal Label label12;
        internal Label label11;
        internal NumericUpDown PrecioNumericUpDown;
        internal Button AsignarAutoButton;
        internal Button QuitarAutoButton;
        internal DataGridView AutosAsignadosDataGridView;
        internal Label label13;
        internal ErrorProvider ErrorProvider;
        internal TextBox AñoTextBox;
        internal Label label14;
    }
}
