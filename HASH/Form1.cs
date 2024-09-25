using System.Threading.Tasks; // Директива для многозадачности.
using System.Security.Cryptography; // Директива для HASH

namespace HASH
{
    public partial class Form1 : Form
    {
        public long[] res1 = new long[3]; //Реузьтат взлома при однозадачном режиме (первой задачи)
        public long[] res2 = new long[3]; //Реузьтат взлома второй задачи
        public long timeRes1; // Длительность взлома при однозадачном режмие (первой задачи)
        public long timeRes2; // Длительность взлома для второй задачи
        public int min = 0;
        public int max = 9999999;
        public Form1()
        {
            InitializeComponent();
            minValue.Text = min.ToString();
            maxValue.Text = max.ToString();
            value.Text = (max / 2).ToString();
            trackBar.Minimum = min;
            trackBar.Maximum = max;
            trackBar.Value = max / 2;
        }


        private void handleScroll(object sender, EventArgs e)
        {
            int scrollValue = trackBar.Value;
            value.Text = scrollValue.ToString();
        }

        public string calcMD(int i)
        {
            byte[] encodedPassword = new System.Text.UTF8Encoding().GetBytes(i.ToString());
            //Переведем входную строку в массив байт
            byte[] hashMD5 = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            string encodedMD5 = BitConverter.ToString(hashMD5).Replace("-", string.Empty).ToLower();
            return encodedMD5;
        }

        public long[] passCrack(string pass, int min, int max)
        {
            long[] j = new long[3];
            j[0] = 0;
            j[1] = DateTime.Now.Ticks;

            for (int i = min; i < max; i++)
            {
                if (calcMD(i) == pass) //если хеш пароля совпадает, то досрочно заврешаем цикл
                {
                    j[0] = i;
                    j[2] = DateTime.Now.Ticks;
                    return j;
                }
            }

            j[2] = DateTime.Now.Ticks;
            return j;
        }

        public void resetFormText()
        {
            passwordText1.Text = "";
            passwordText2.Text = "";
            timeStart1.Text = "";
            timeStart2.Text = "";
            timeEnd1.Text = "";
            timeEnd2.Text = "";
            time1.Text = "";
            time2.Text = "";
        }

        private void genHashButton_click(object sender, EventArgs e)
        {
            string hashPass = calcMD(int.Parse(password.Text));
            hash.Text = hashPass;
        }

        private void monoTaskButton_Click(object sender, EventArgs e)
        {
            resetFormText();

            // Взлом
            res1 = passCrack(hash.Text, min, max);// Взлом

            //Вывод результата взлома пароля
            if (res1[0] == 0) passwordText1.Text = "Пароль не взломан";
            else passwordText1.Text = "Пароль: " + res1[0].ToString();

            timeRes1 = res1[2] - res1[1];

            timeStart1.Text = res1[1].ToString();
            timeEnd1.Text = res1[2].ToString();
            time1.Text = (timeRes1 / TimeSpan.TicksPerMillisecond).ToString();
        }

        private void duoTaskButton_click(object sender, EventArgs e)
        {
            resetFormText();

            Task task1 = new Task(() => res1 = passCrack(hash.Text, min, int.Parse(value.Text)));
            task1.Start();
            task1.Wait();

            Task task2 = new Task(() => res2 = passCrack(hash.Text, int.Parse(value.Text), max));
            task2.Start();
            task2.Wait();

            //Вывод результата взлома пароля для первой задачи
            if (res1[0] == 0) passwordText1.Text = "Пароль не взломан";
            else passwordText1.Text = "Пароль: " + res1[0].ToString();

            timeRes1 = res1[2] - res1[1];

            timeStart1.Text = res1[1].ToString();
            timeEnd1.Text = res1[2].ToString();
            time1.Text = (timeRes1 / TimeSpan.TicksPerMillisecond).ToString();

            //Вывод результата взлома пароля для второй задачи
            if (res2[0] == 0) passwordText2.Text = "Пароль не взломан";
            else passwordText2.Text = "Пароль: " + res2[0].ToString();

            timeRes2 = res2[2] - res2[1];

            timeStart2.Text = res2[1].ToString();
            timeEnd2.Text = res2[2].ToString();
            time2.Text = (timeRes2 / TimeSpan.TicksPerMillisecond).ToString();
        }
    }
}
