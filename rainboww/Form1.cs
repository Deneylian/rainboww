namespace rainboww
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int[] cl_button = new int[7]; // ћассив дл€ хранени€ уникальных чисел
            HashSet<int> uniqueNumbers = new HashSet<int>(); // HashSet дл€ генерации уникальных чисел
            Random random = new Random();
            while (uniqueNumbers.Count < 7)
            {
                int number = random.Next(0, 6); // —лучайное число от 0 до 6 включительно
                uniqueNumbers.Add(number); // ƒобавл€ем число в HashSet (дубликаты игнорируютс€)
            }
            uniqueNumbers.CopyTo(cl_button); //  опируем уникальные числа из HashSet в массив
            switch (cl_button[0])
            {
                case 0:
                    button1.BackColor = Color.Red;
                    break;
                case 1:
                    button1.BackColor = Color.Orange;
                    break;
                case 2:
                    button1.BackColor = Color.Yellow;
                    break;
                case 3:
                    button1.BackColor = Color.Green;
                    break;
                case 4:
                    button1.BackColor = Color.Blue;
                    break;
                case 5:
                    button1.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    button1.BackColor = Color.Purple;
                    break;

            }
            switch (cl_button[1])
            {
                case 0:
                    button2.BackColor = Color.Red;
                    break;
                case 1:
                    button2.BackColor = Color.Orange;
                    break;
                case 2:
                    button2.BackColor = Color.Yellow;
                    break;
                case 3:
                    button2.BackColor = Color.Green;
                    break;
                case 4:
                    button2.BackColor = Color.Blue;
                    break;
                case 5:
                    button2.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    button2.BackColor = Color.Purple;
                    break;
            }
            switch (cl_button[2])
            {
                case 0:
                    button3.BackColor = Color.Red;
                    break;
                case 1:
                    button3.BackColor = Color.Orange;
                    break;
                case 2:
                    button3.BackColor = Color.Yellow;
                    break;
                case 3:
                    button3.BackColor = Color.Green;
                    break;
                case 4:
                    button3.BackColor = Color.Blue;
                    break;
                case 5:
                    button3.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    button3.BackColor = Color.Purple;
                    break;

            }
            switch (cl_button[3])
            {
                case 0:
                    button4.BackColor = Color.Red;
                    break;
                case 1:
                    button4.BackColor = Color.Orange;
                    break;
                case 2:
                    button4.BackColor = Color.Yellow;
                    break;
                case 3:
                    button4.BackColor = Color.Green;
                    break;
                case 4:
                    button4.BackColor = Color.Blue;
                    break;
                case 5:
                    button4.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    button4.BackColor = Color.Purple;
                    break;
            }
            switch (cl_button[4])
            {
                case 0:
                    button5.BackColor = Color.Red;
                    break;
                case 1:
                    button5.BackColor = Color.Orange;
                    break;
                case 2:
                    button5.BackColor = Color.Yellow;
                    break;
                case 3:
                    button5.BackColor = Color.Green;
                    break;
                case 4:
                    button5.BackColor = Color.Blue;
                    break;
                case 5:
                    button5.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    button5.BackColor = Color.Purple;
                    break;
            }
            switch (cl_button[5])
            {
                case 0:
                    button6.BackColor = Color.Red;
                    break;
                case 1:
                    button6.BackColor = Color.Orange;
                    break;
                case 2:
                    button6.BackColor = Color.Yellow;
                    break;
                case 3:
                    button6.BackColor = Color.Green;
                    break;
                case 4:
                    button6.BackColor = Color.Blue;
                    break;
                case 5:
                    button6.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    button6.BackColor = Color.Purple;
                    break;
            }
            switch (cl_button[6])
            {
                case 0:
                    button7.BackColor = Color.Red;
                    break;
                case 1:
                    button7.BackColor = Color.Orange;
                    break;
                case 2:
                    button7.BackColor = Color.Yellow;
                    break;
                case 3:
                    button7.BackColor = Color.Green;
                    break;
                case 4:
                    button7.BackColor = Color.Blue;
                    break;
                case 5:
                    button7.BackColor = Color.DarkBlue;
                    break;
                case 6:
                    button7.BackColor = Color.Purple;
                    break;
            }
        }
    }
}
