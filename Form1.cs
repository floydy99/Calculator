using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalc
{

	public static class CalculatorFunctions///To klasa z funkcjami liczącymi kalkulatora
	{
        public static double perform_Operation(char znak, double a, double b)///Wykonuje operację matematyczną wskazaną przez znak "char znak" na liczbach a i b.
		{
            double c = 0;///wykonuje operacje zależnie od znaku
			switch (znak)
			{
				case '+':
					c = a + b;///Jeśli znak jest równy plus, to jest w nim napisany symbol plus c = a + b;
					break;
				case '-':
					c = a - b;///Jeśli znak jest równy minus, to jest w nim napisany symbol plus c = a - b;
					break;
				case '×':
					c = a * b;///Jeśli znak jest równy mnożenie, to jest w nim napisany symbol mnożenie c = a * b;
					break;
				case '÷':
					c = a / b;///Jeśli znak jest równy dzielenie, to jest w nim napisany symbol dzielenie c = a / b;
					break;
			}
			return c;///Instrukcja return ma dwa cele. Po pierwsze, natychmiastowa funkcja wyjścia. Oznacza to, że zapewnia dostęp do kodu, który wywołał funkcję. Po drugie, można go użyć do zwrócenia wartości. Oba cele są tutaj rozważane.
		}
    }


	public partial class Form1 : Form/// Klasa o nazwie Form1 jest następcą klasy Form
2
	{
		public Form1()/// Zdarzenia w formularzach Windows reprezentują standardowe zdarzenia C #, które dotyczą tylko komponentów wizualnych i przestrzegają tych samych reguł, co zdarzenia w C #.
		{
			InitializeComponent();///Metoda inicjująca wszystkie składniki znajdujące się w formularzu: pola, przyciski, menu, przełączniki i tak dalej.
		}

        public void button10_Click(object sender, EventArgs e)///EventArgs e jest parametrem o nazwie e, który zawiera dane zdarzeń, zobacz stronę EventArgs MSDN, aby uzyskać więcej informacji. Nadawca obiektów to parametr o nazwie Nadawca, który zawiera odwołanie do kontrolki / obiektu, który wywołał zdarzenie.
		{
            textBox1.Text += (sender as Button).Text;///Do tego bloku tekstowego zostanie dodany tekst odstępów między przyciskami
		}

		double a = 0, b = 0, c = 0; ///Zmienne w nich piszemy liczby
		char znak = '+'; ///Znak char który zapamięta znak działania 

		public double getc()
		{
			return c;///Instrukcja return ma dwa cele. Po pierwsze, natychmiastowa funkcja wyjścia. Oznacza to, że zapewnia dostęp do kodu, który wywołał funkcję. Po drugie, można go użyć do zwrócenia wartości. Oba cele są tutaj rozważane.
		}

        public double geta()
		{
			return a;///Instrukcja return ma dwa cele. Po pierwsze, natychmiastowa funkcja wyjścia. Oznacza to, że zapewnia dostęp do kodu, który wywołał funkcję. Po drugie, można go użyć do zwrócenia wartości. Oba cele są tutaj rozważane.
		}

        public void seta(double value)///double: Podwójny typ danych to 64-bitowa zmiennoprzecinkowa podwójna precyzja IEEE 754.
		{
            a = value;///Wartość słowa kluczowego kontekstowego jest używana w ustawionej metodzie dostępowej w zwykłych deklaracjach właściwości.
		}

        private void button12_Click(object sender, EventArgs e)///Do tego bloku tekstowego zostanie dodany tekst odstępów między przyciskami
		{
				b = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture); ///Tłumaczymy tekst napisany w bloku tekstowym typu double to jest znak (=);
			c = CalculatorFunctions.perform_Operation(znak, a, b);///Operatory służą do sterowania zmiennymi i wartościami w programie.C # obsługuje wiele instrukcji, które są klasyfikowane zgodnie z rodzajem wykonywanych operacji.
			textBox1.Text = c.ToString();///Ciąg jest obiektem typu String, którego wartością jest tekst. Wewnątrz programu tekst jest przechowywany jako uporządkowany zbiór obiektów tylko do odczytu.
		}



        private void button17_Click(object sender, EventArgs e)///Do tego bloku tekstowego zostanie dodany tekst odstępów między przyciskami
		{
			textBox1.Clear();///Ten block tekstowy ma funkcja "C". Za jego pomocą usuwamy linię równania
		}

		private void button16_Click(object sender, EventArgs e)///Do tego bloku tekstowego zostanie dodany tekst odstępów między przyciskami
		{
			if (textBox1.Text != "±")///Ten blok tekstowy ma znak (±);
			{
				;
			}

			if (textBox1.Text[0] == '-')///Funkcja TextBox Control jest zwykle używana do wprowadzania i edytowania tekstu, chociaż może być również tylko do odczytu.
				textBox1.Text = textBox1.Text.Remove(0, 1);///Usuwa pierwszy znak ze stringa
			else textBox1.Text = '-' + textBox1.Text;///Ustawia znak - (minus) na początku stringa

        }

        private void button20_Click(object sender, EventArgs e)///Do tego bloku tekstowego zostanie dodany tekst odstępów między przyciskami
		{
			if (textBox1.Text != "")
			{///Za pomocą tego bloka my możemy wyczyść jeden znak lub wszystkie
				textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);///Usuwa ostatni znak ze stringa.
			}
        }

		private void button3_Click(object sender, EventArgs e)///Do tego bloku tekstowego zostanie dodany tekst odstępów między przyciskami
		{

		}

		private void button13_Click(object sender, EventArgs e)///Do tego bloku tekstowego zostanie dodany tekst odstępów między przyciskami
		{
		
			a = Double.Parse(textBox1.Text, CultureInfo.InvariantCulture);///Ten blok tekstowy ma znak (+,-,÷,x);
			znak = (sender as Button).Text[0];///Przypuśćmy, że wprowadziłem 3 + 3 i jeśli kliknę ponownie „+”, chcę uzyskać wynik „6” i tak dalej.
			textBox1.Clear();///Wyraźny zapis

        }
	}
}
