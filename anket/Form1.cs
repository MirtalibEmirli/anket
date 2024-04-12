
using anket.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using System.Xml.Linq;
namespace anket;

public partial class Form1 : Form
{
    public List<Userr> users = new List<Userr>();

    public Form1()
    {
        InitializeComponent();

        listBox1.DataSource = users;
    }
    void Jsonwrite()
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string data = JsonSerializer.Serialize<List<Userr>>(users, options);
        File.WriteAllText($"../../../{filename.Text}.json", data);
    }

    void JSonread()
    {
        if (File.Exists($"../../../{filename.Text}.json"))
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string txt = File.ReadAllText($"../../../{filename.Text}.json");
            users = JsonSerializer.Deserialize<List<Userr>>(txt, options).ToList();
            listBox1.DataSource = null;
            listBox1.DataSource = users;
        }

    }
    private void load_Click(object sender, EventArgs e)
    {
        JSonread();

    }

    private void save_Click(object sender, EventArgs e)
    {
        Jsonwrite();
    }

    private void add_Click(object sender, EventArgs e)
    {
        Userr u1 = new Userr(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value);
        if (u1 != null)
        {
            users.Add(u1);
            listBox1.DataSource = null;
            listBox1.DataSource = users;
        }
    }

    private void change_Click(object sender, EventArgs e)
    {
        foreach (var item in users)
        {
            if (listBox1.SelectedItem.ToString() == item.Name)
            {
             item.Name = textBox1.Text;
               item.SurName = textBox2.Text ;
                item.Email  =textBox3.Text;
              item.Number = textBox4.Text;
                item.Birthdate= dateTimePicker1.Value ;
                listBox1.DataSource = null;
                listBox1.DataSource = users;    
            }
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (var item in users)
        {
            if (listBox1.SelectedItem.ToString() == item.Name)
            {
                textBox1.Text = item.Name;
                textBox2.Text = item.SurName;
                textBox3.Text = item.Email;
                textBox4.Text = item.Number;
                dateTimePicker1.Value = item.Birthdate;
            }
        }
    }
}
