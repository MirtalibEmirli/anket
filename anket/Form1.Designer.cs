namespace anket;

partial class Form1
{
    
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        form = new Label();
        name = new Label();
        surname = new Label();
        email = new Label();
        number = new Label();
        birthdate = new Label();
        listBox1 = new ListBox();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        change = new Button();
        add = new Button();
        filename = new TextBox();
        load = new Button();
        save = new Button();
        dateTimePicker1 = new DateTimePicker();
        SuspendLayout();
        // 
        // form
        // 
        form.AutoSize = true;
        form.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        form.Location = new Point(31, 23);
        form.Name = "form";
        form.Size = new Size(94, 31);
        form.TabIndex = 0;
        form.Text = "Formm";
        // 
        // name
        // 
        name.AutoSize = true;
        name.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
        name.Location = new Point(31, 62);
        name.Name = "name";
        name.Size = new Size(55, 23);
        name.TabIndex = 1;
        name.Text = "Name";
        // 
        // surname
        // 
        surname.AutoSize = true;
        surname.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
        surname.Location = new Point(31, 102);
        surname.Name = "surname";
        surname.Size = new Size(75, 23);
        surname.TabIndex = 2;
        surname.Text = "Surname";
        // 
        // email
        // 
        email.AutoSize = true;
        email.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
        email.Location = new Point(31, 152);
        email.Name = "email";
        email.Size = new Size(50, 23);
        email.TabIndex = 3;
        email.Text = "Email";
        // 
        // number
        // 
        number.AutoSize = true;
        number.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
        number.Location = new Point(31, 197);
        number.Name = "number";
        number.Size = new Size(70, 23);
        number.TabIndex = 4;
        number.Text = "Number";
        // 
        // birthdate
        // 
        birthdate.AutoSize = true;
        birthdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
        birthdate.Location = new Point(31, 243);
        birthdate.Name = "birthdate";
        birthdate.Size = new Size(77, 23);
        birthdate.TabIndex = 5;
        birthdate.Text = "Birthdate";
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 20;
        listBox1.Location = new Point(477, 23);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(283, 344);
        listBox1.TabIndex = 6;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(142, 66);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(125, 27);
        textBox1.TabIndex = 7;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(142, 102);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(125, 27);
        textBox2.TabIndex = 8;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(142, 149);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(125, 27);
        textBox3.TabIndex = 9;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(142, 193);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(125, 27);
        textBox4.TabIndex = 10;
        // 
        // change
        // 
        change.Location = new Point(258, 336);
        change.Name = "change";
        change.Size = new Size(94, 29);
        change.TabIndex = 12;
        change.Text = "Change";
        change.UseVisualStyleBackColor = true;
        change.Click += change_Click;
        // 
        // add
        // 
        add.Location = new Point(258, 373);
        add.Name = "add";
        add.Size = new Size(94, 29);
        add.TabIndex = 14;
        add.Text = "Add";
        add.UseVisualStyleBackColor = true;
        add.Click += add_Click;
        // 
        // filename
        // 
        filename.Location = new Point(477, 376);
        filename.Name = "filename";
        filename.PlaceholderText = "Filename";
        filename.Size = new Size(283, 27);
        filename.TabIndex = 15;
        // 
        // load
        // 
        load.Location = new Point(492, 409);
        load.Name = "load";
        load.Size = new Size(94, 29);
        load.TabIndex = 16;
        load.Text = "Load";
        load.UseVisualStyleBackColor = true;
        load.Click += load_Click;
        // 
        // save
        // 
        save.Location = new Point(615, 409);
        save.Name = "save";
        save.Size = new Size(94, 29);
        save.TabIndex = 17;
        save.Text = "Save";
        save.UseVisualStyleBackColor = true;
        save.Click += save_Click;
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
        dateTimePicker1.Format = DateTimePickerFormat.Short;
        dateTimePicker1.Location = new Point(132, 237);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(135, 30);
        dateTimePicker1.TabIndex = 18;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(772, 450);
        Controls.Add(dateTimePicker1);
        Controls.Add(save);
        Controls.Add(load);
        Controls.Add(filename);
        Controls.Add(add);
        Controls.Add(change);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(listBox1);
        Controls.Add(birthdate);
        Controls.Add(number);
        Controls.Add(email);
        Controls.Add(surname);
        Controls.Add(name);
        Controls.Add(form);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label form;
    private Label name;
    private Label surname;
    private Label email;
    private Label number;
    private Label birthdate;
    private ListBox listBox1;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private Button change;
    private Button add;
    private TextBox filename;
    private Button load;
    private Button save;
    private DateTimePicker dateTimePicker1;
}
