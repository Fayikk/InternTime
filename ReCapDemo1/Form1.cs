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
            Button button5 = new Button();//Burada asýl anlatýlmak istenen konu ise þudur.
                                          //C# formda toolbox ile eklenen her brþ buton aslýnda bir sýnýfa tekabil etmektedir.
                                          //Biz bu sýnýfýn nesnesini oluþturup gerekli parameterlei verdiðimiz zaman class'ýn property veya metodlarýna eriþim saðlayabilmekteyiz
                                          //Bunu yalnýzca button için söylemiyorum form pencereside dahil aslýda etkileþim kurabildiðimiz herþeyi bir Class(sýnýf) olarak düþünebilmeliyiz.

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