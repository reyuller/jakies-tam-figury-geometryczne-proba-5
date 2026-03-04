using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jakies_tam_figury_geometryczne_proba_5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			sigmabox.Items.Add("Prostokąt");
			sigmabox.Items.Add("Kwadrat");
			sigmabox.Items.Add("Koło");
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			double a, b = 0, pole = 0;

			if (string.IsNullOrWhiteSpace(textBox1.Text) ||
				sigmabox.SelectedIndex == -1)
			{
				MessageBox.Show("Wypełnij wymagane pola");
				return;
			}

			if (!double.TryParse(textBox1.Text, out a))
			{
				MessageBox.Show("Podaj liczbe w bok1");
				return;
			}
			if (sigmabox.SelectedItem.ToString() != "Koło")
			{
				if (string.IsNullOrWhiteSpace(textBox2.Text) ||
					!double.TryParse(textBox2.Text, out b))
				{
					MessageBox.Show("Podaj liczbe w bok2");
					return;
				}
			}

			switch (sigmabox.SelectedItem.ToString())
			{
				case "Prostokąt":
					pole = a * b;
					break;

				case "Kwadrat":
					pole = a * a;
					break;

				case "Koło":
					pole = Math.PI * a * a;
					break;
			}

			labelwynikas.Text = "" + pole.ToString("");
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			double a, b = 0, obwod = 0;

			if (string.IsNullOrWhiteSpace(textBox1.Text) ||
				sigmabox.SelectedIndex == -1)
			{
				MessageBox.Show("Wypełnij wymagane pola");
				return;
			}

			if (!double.TryParse(textBox1.Text, out a))
			{
				MessageBox.Show("Podaj liczbe w bok1");
				return;
			}
			if (sigmabox.SelectedItem.ToString() != "Koło")
			{
				if (string.IsNullOrWhiteSpace(textBox2.Text) ||
					!double.TryParse(textBox2.Text, out b))
				{
					MessageBox.Show("Podaj liczbe w bok2");
					return;
				}
			}

			switch (sigmabox.SelectedItem.ToString())
			{
				case "Prostokąt":
					obwod = 2 * (a + b);
					break;

				case "Kwadrat":
					obwod = a * 4;
					break;

				case "Koło":
					obwod = 2 * Math.PI * a; ;
					break;
			}

			labelwynikas.Text = "" + obwod.ToString("");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			labelwynikas.Text = "";
		}
	}
}
//chyba mi to troche za dużo linjek kodu zajelo