namespace ReCapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button5 = new Button();//Burada as�l anlat�lmak istenen konu ise �udur.
                                          //C# formda toolbox ile eklenen her br� buton asl�nda bir s�n�fa tekabil etmektedir.
                                          //Biz bu s�n�f�n nesnesini olu�turup gerekli parameterlei verdi�imiz zaman class'�n property veya metodlar�na eri�im sa�layabilmekteyiz
                                          //Bunu yaln�zca button i�in s�ylemiyorum form pencereside dahil asl�da etkile�im kurabildi�imiz her�eyi bir Class(s�n�f) olarak d���nebilmeliyiz.

            Button[,] buttons = new Button[8,8];

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j >=buttons.GetUpperBound(0); i--)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i,j].Text = buttons[i,j].ToString();
                }

            }


            button5.Width = 50;
            button5.Height = 50;
            button5.Text = "Benim Butonum";
            this.Controls.Add(button5);


        }
    }
}