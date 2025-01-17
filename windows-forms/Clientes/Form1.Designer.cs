namespace Clientes
{
    partial class RegisterBtn
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
            lblText = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblCpf = new Label();
            lblAdress = new Label();
            emailBox = new TextBox();
            adressBox = new TextBox();
            registerBtt = new Button();
            lblId = new Label();
            IdBox = new Label();
            searchBtt = new Button();
            updateBtt = new Button();
            deleteBtt = new Button();
            toolTip = new ToolTip(components);
            cpfBox = new MaskedTextBox();
            nameBox = new TextBox();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(13, 61);
            lblText.Name = "lblText";
            lblText.Size = new Size(0, 15);
            lblText.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(16, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(16, 133);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-mail:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(19, 235);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(39, 20);
            lblCpf.TabIndex = 3;
            lblCpf.Text = "CPF:";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdress.Location = new Point(16, 183);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(72, 20);
            lblAdress.TabIndex = 4;
            lblAdress.Text = "Endereço:";
            // 
            // emailBox
            // 
            emailBox.Font = new Font("Arial", 12F);
            emailBox.Location = new Point(93, 127);
            emailBox.MaxLength = 100;
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(391, 26);
            emailBox.TabIndex = 2;
            // 
            // adressBox
            // 
            adressBox.Font = new Font("Arial", 12F);
            adressBox.Location = new Point(93, 178);
            adressBox.MaxLength = 250;
            adressBox.Name = "adressBox";
            adressBox.Size = new Size(391, 26);
            adressBox.TabIndex = 3;
            // 
            // registerBtt
            // 
            registerBtt.FlatStyle = FlatStyle.Flat;
            registerBtt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerBtt.Location = new Point(93, 27);
            registerBtt.Name = "registerBtt";
            registerBtt.Size = new Size(90, 30);
            registerBtt.TabIndex = 5;
            registerBtt.Text = "Cadastrar";
            toolTip.SetToolTip(registerBtt, "- TODOS os CAMPOS devem estar PREENCHIDOS para concluir o cadastro.\r\n- O CPF digitado NÃO pode estar REGISTRADO.");
            registerBtt.UseVisualStyleBackColor = true;
            registerBtt.Click += RegisterBtn_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial Narrow", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(16, 319);
            lblId.Name = "lblId";
            lblId.Size = new Size(77, 13);
            lblId.TabIndex = 20;
            lblId.Text = "ID do Funcionario:";
            // 
            // IdBox
            // 
            IdBox.AutoSize = true;
            IdBox.Location = new Point(93, 317);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(0, 15);
            IdBox.TabIndex = 7;
            // 
            // searchBtt
            // 
            searchBtt.FlatStyle = FlatStyle.Flat;
            searchBtt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtt.Location = new Point(239, 280);
            searchBtt.Name = "searchBtt";
            searchBtt.Size = new Size(90, 30);
            searchBtt.TabIndex = 6;
            searchBtt.Text = "Pesquisar";
            toolTip.SetToolTip(searchBtt, "- DIGITE um CPF valido para fazer uma CONSULTA.\r\n");
            searchBtt.UseVisualStyleBackColor = true;
            searchBtt.Click += SearchBtt_Click;
            // 
            // updateBtt
            // 
            updateBtt.FlatStyle = FlatStyle.Flat;
            updateBtt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtt.Location = new Point(239, 27);
            updateBtt.Name = "updateBtt";
            updateBtt.Size = new Size(90, 30);
            updateBtt.TabIndex = 7;
            updateBtt.Text = "Atualizar";
            toolTip.SetToolTip(updateBtt, "- PREENCHA todos os campos CORRETAMENTE para EDITAR um CADASTRO.\r\n- NOME e CPF são dados INALTERAVEIS.\r\n");
            updateBtt.UseVisualStyleBackColor = true;
            updateBtt.Click += UpdateBtt_Click;
            // 
            // deleteBtt
            // 
            deleteBtt.FlatStyle = FlatStyle.Flat;
            deleteBtt.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtt.Location = new Point(394, 27);
            deleteBtt.Name = "deleteBtt";
            deleteBtt.Size = new Size(90, 30);
            deleteBtt.TabIndex = 8;
            deleteBtt.Text = "Deletar";
            deleteBtt.UseVisualStyleBackColor = true;
            deleteBtt.Click += DeleteBtt_Click;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 9000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 180;
            toolTip.ShowAlways = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Ajuda:";
            // 
            // cpfBox
            // 
            cpfBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpfBox.Location = new Point(93, 233);
            cpfBox.Mask = "000,000,000-00";
            cpfBox.Name = "cpfBox";
            cpfBox.Size = new Size(391, 26);
            cpfBox.TabIndex = 4;
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameBox.Location = new Point(93, 85);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(391, 26);
            nameBox.TabIndex = 21;
            // 
            // RegisterBtn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 341);
            Controls.Add(nameBox);
            Controls.Add(deleteBtt);
            Controls.Add(cpfBox);
            Controls.Add(updateBtt);
            Controls.Add(searchBtt);
            Controls.Add(IdBox);
            Controls.Add(lblId);
            Controls.Add(registerBtt);
            Controls.Add(adressBox);
            Controls.Add(emailBox);
            Controls.Add(lblAdress);
            Controls.Add(lblCpf);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterBtn";
            RightToLeft = RightToLeft.No;
            Text = "Gerenciador de clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private Label lblName;
        private Label lblEmail;
        private Label lblCpf;
        private Label lblAdress;
        private TextBox emailBox;
        private TextBox adressBox;
        private Button registerBtt;
        private Label lblId;
        private Label IdBox;
        private Button searchBtt;
        private Button updateBtt;
        private ToolTip toolTip;
        private MaskedTextBox cpfBox;
        private Button deleteBtt;
        private TextBox nameBox;
    }
}
