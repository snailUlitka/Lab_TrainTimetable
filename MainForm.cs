using System.Text.RegularExpressions;

namespace Lab3_40
{
    public partial class MainForm : Form
    {
        private CycleDoubleLinkedList trainList;

        public MainForm()
        {
            InitializeComponent();
            trainList = new();
        }

        # region MenuStrip Buttons
        private void ExitMenuItem_Click(object sender, EventArgs e) // Выход из формы
        {
            Close();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e) // Вызов справки
        {
            ResetViews();

            About_Lbl.Visible = !About_Lbl.Visible;
            About_Lbl.AutoSize = !About_Lbl.AutoSize;
        }

        private void CreateMenuItem_Click(object sender, EventArgs e) // Инициализация элементов для создания списка
        {
            ResetViews();
            trainList = new();

            SetColumns();

            MultiBtn.Click += Save_Click!;
            MultiBtn.Text = "Сохранить";

            TrainsheetGridView.Visible = true;
            MultiBtn.Visible = true;
        }

        private void AddFirstMenuItem_Click(object sender, EventArgs e) // Иницализация элементов для добавления элемента в начало списка
        {
            ResetViews();

            SetColumns();

            MultiBtn.Text = "Добавить";
            MultiBtn.Click += AddFirst_Click!;

            TrainsheetGridView.AllowUserToAddRows = false;
            TrainsheetGridView.RowCount = 1;

            TrainsheetGridView.Visible = true;
            MultiBtn.Visible = true;

            if (!trainList.IsExist())
            {
                trainList = new();
            }
        }

        private void AddLastMenuItem_Click(object sender, EventArgs e) // Иницализация элементов для добавления элемента в конец списка
        {
            ResetViews();

            SetColumns();

            MultiBtn.Text = "Добавить";
            MultiBtn.Click += AddLast_Click!;

            TrainsheetGridView.AllowUserToAddRows = false;
            TrainsheetGridView.RowCount = 1;

            TrainsheetGridView.Visible = true;
            MultiBtn.Visible = true;

            if (!trainList.IsExist())
            {
                trainList = new();
            }
        }

        private void AddCustomMenuItem_Click(object sender, EventArgs e) // Иницализация элементов для добавления элемента в спискок
        {
            ResetViews();

            SetColumns();

            MultiBtn.Text = "Добавить";
            MultiBtn.Click += AddCustom_Click!;

            TrainsheetGridView.AllowUserToAddRows = false;
            TrainsheetGridView.RowCount = 1;

            Info_Lbl.Text = "Добавить после...";
            Input_Txt.TextChanged += Input_Number_TextChanged!;

            TrainsheetGridView.Visible = true;
            MultiBtn.Visible = true;
            Info_Lbl.Visible = true;
            Input_Txt.Visible = true;

            if (!trainList.IsExist())
            {
                trainList = new();
            }
        }

        private void DeleteFirstMenuItem_Click(object sender, EventArgs e) // Удаляет первый элемент
        {
            ResetViews();

            trainList.DeleteFirst();
        }

        private void DeleteLastMenuItem_Click(object sender, EventArgs e) // Удаляет последний элемент
        {
            ResetViews();

            trainList.DeleteLast();
        }

        private void DeleteCustomMenuItem_Click(object sender, EventArgs e) // Инициализация элементов для удаления из списка
        {
            ResetViews();

            Info_Lbl.Text = "Удалить...";
            Input_Txt.TextChanged += Input_Number_TextChanged!;

            MultiBtn.Text = "Удалить";
            MultiBtn.Click += DeleteCustom_Click!;

            Info_Lbl.Visible = true;
            Input_Txt.Visible = true;
            MultiBtn.Visible = true;
        }

        private void NumberOutputMenuItem_Click(object sender, EventArgs e) // Вывод поезда с выбраным номером
        {
            if (trainList.IsExist() && !trainList.IsEmpty())
            {
                ResetViews();

                SetColumns();

                TrainsheetGridView.ReadOnly = true;
                TrainsheetGridView.RowCount = 1;

                Info_Lbl.Text = "Данные о...\n(номер)";
                Input_Txt.TextChanged += Input_Number_TextChanged!;

                MultiBtn.Text = "Вывод";
                MultiBtn.Click += SetNumber_Click!;

                MultiBtn.Visible = true;
                Info_Lbl.Visible = true;
                Input_Txt.Visible = true;
            }
            else
            {
                MessageBox.Show("Список пуст или не существует", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AllOutputMenuItem_Click(object sender, EventArgs e) // Вывод информации обо всех поездах
        {
            if (trainList.IsExist() && !trainList.IsEmpty())
            {
                ResetViews();

                SetColumns();

                TrainsheetGridView.ReadOnly = true;
                TrainsheetGridView.RowCount = trainList.GetCount();

                DoubleNode p = trainList.Head!.Next!;
                int i = 0;

                while (p != trainList.Head)
                {
                    TrainsheetGridView.Rows[i].Cells[0].Value = p.TrainNumber;
                    TrainsheetGridView.Rows[i].Cells[1].Value = p.StationName;
                    TrainsheetGridView.Rows[i].Cells[2].Value = p.DepatureTime;

                    p = p.Next!;
                    i++;
                }

                TrainsheetGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("Список пуст или не существует", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void StationOutputMenuItem_Click(object sender, EventArgs e) // Вывод поездов с конечной станцией на выбор
        {
            if (trainList.IsExist() && !trainList.IsEmpty())
            {
                ResetViews();

                SetColumns();

                TrainsheetGridView.ReadOnly = true;

                Info_Lbl.Text = "Данные о...\n(станция)";

                MultiBtn.Text = "Вывод";
                MultiBtn.Click += SetName_Click!;

                MultiBtn.Visible = true;
                Info_Lbl.Visible = true;
                Input_Txt.Visible = true;
            }
            else
            {
                MessageBox.Show("Список пуст или не существует", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DestroyMenuItem_Click(object sender, EventArgs e) // Уничтожает список
        {
            ResetViews();
            trainList.Destroy();
        }

        #endregion

        #region MultiButton Events

        private void Save_Click(object sender, EventArgs e) // Сохранение данных из таблицы создания в односвязный список
        {
            int listLen = TrainsheetGridView.RowCount - 1;

            int[] trainNumbers = new int[listLen];
            string[] stationNames = new string[listLen];
            string[] depatureTimes = new string[listLen];

            for (int i = 0; i < listLen; i++)
            {
                trainNumbers[i] = int.Parse(TrainsheetGridView.Rows[i].Cells[0].Value?.ToString() ?? "404");
                stationNames[i] = TrainsheetGridView.Rows[i].Cells[1].Value?.ToString() ?? "404";
                depatureTimes[i] = TrainsheetGridView.Rows[i].Cells[2].Value?.ToString() ?? "04:04";
            }

            trainList.Create(trainNumbers, stationNames, depatureTimes);
        }

        private void AddFirst_Click(object sender, EventArgs e) // Добавление элемента в начало списка
        {
            int trainNumber = int.Parse(TrainsheetGridView.Rows[0].Cells[0].Value?.ToString() ?? "404");
            string stationName = TrainsheetGridView.Rows[0].Cells[1].Value?.ToString() ?? "404";
            string depatureTime = TrainsheetGridView.Rows[0].Cells[2].Value?.ToString() ?? "04:04";

            if (AlreadyExist(trainNumber))
            {
                MessageBox.Show("Поезд с таким номером уже существует", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                trainList.InsertBeforeFirst(trainNumber, stationName, depatureTime);
            }
        }

        private void AddLast_Click(object sender, EventArgs e) // Добавление элемента в конец списка
        {
            int trainNumber = int.Parse(TrainsheetGridView.Rows[0].Cells[0].Value?.ToString() ?? "404");
            string stationName = TrainsheetGridView.Rows[0].Cells[1].Value?.ToString() ?? "404";
            string depatureTime = TrainsheetGridView.Rows[0].Cells[2].Value?.ToString() ?? "04:04";

            if (AlreadyExist(trainNumber))
            {
                MessageBox.Show("Поезд с таким номером уже существует", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                trainList.InsertAfterAll(trainNumber, stationName, depatureTime);
            }
        }

        private void AddCustom_Click(object sender, EventArgs e) // Добавление элемента в список
        {
            int trainNumber = int.Parse(TrainsheetGridView.Rows[0].Cells[0].Value?.ToString() ?? "404");
            string stationName = TrainsheetGridView.Rows[0].Cells[1].Value?.ToString() ?? "404";
            string depatureTime = TrainsheetGridView.Rows[0].Cells[2].Value?.ToString() ?? "04:04";

            int afterTrainNumber = int.Parse(Input_Txt.Text);

            if (trainList.IsEmpty())
            {
                MessageBox.Show("Список пуст, создайте список используя \"Создание\"", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (AlreadyExist(trainNumber))
            {
                MessageBox.Show("Поезда с таким номером уже существует", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                trainList.InsertAfter(trainNumber, stationName, depatureTime, trainList.Search(afterTrainNumber)!);
            }
        }

        private void DeleteCustom_Click(object sender, EventArgs e) // Удаляет элемент на выбор
        {
            int trainNumber = int.Parse(Input_Txt.Text);
            DoubleNode? p = trainList.Search(trainNumber);

            if (trainList.IsEmpty())
            {
                MessageBox.Show("Список пуст, создайте список используя \"Создание\"", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                trainList.DeleteCurrent(ref p);
            }
        }

        private void SetNumber_Click(object sender, EventArgs e) // Установка номера для вывода
        {
            DoubleNode? p = trainList.Search(int.Parse(Input_Txt.Text));

            if (p != null)
            {
                TrainsheetGridView.Rows[0].Cells[0].Value = p.TrainNumber;
                TrainsheetGridView.Rows[0].Cells[1].Value = p.StationName;
                TrainsheetGridView.Rows[0].Cells[2].Value = p.DepatureTime;

                TrainsheetGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("Поезда с таким номером не существует", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetName_Click(object sender, EventArgs e) // Вывод поездов по станции
        {
            int trainsCount = trainList.GetCount(Input_Txt.Text);
            TrainsheetGridView.RowCount = trainsCount;

            if (trainsCount > 0)
            {
                DoubleNode p = trainList.Head!.Next!;
                int i = 0;

                while (p != trainList.Head)
                {
                    if (p.StationName == Input_Txt.Text)
                    {
                        TrainsheetGridView.Rows[i].Cells[0].Value = p.TrainNumber;
                        TrainsheetGridView.Rows[i].Cells[1].Value = p.StationName;
                        TrainsheetGridView.Rows[i].Cells[2].Value = p.DepatureTime;
                        i++;
                    }

                    p = p.Next!;
                }

                TrainsheetGridView.Visible = true;
            }
            else
            {
                MessageBox.Show("Не является конечной станцией ни для одного поезда", "INFO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #endregion

        #region Input Check Functions

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // Проверка на подтвержение закрытия формы
        {
            if (ClosingInfo() == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private static DialogResult ClosingInfo() // Окно подтверждения выхода
        {
            DialogResult res =
                MessageBox.Show("Вы хотите выйти?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        private void TrainsheetGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) // Проверки ввода
        {

            if (TrainsheetGridView.Rows.Count > 1)
            {
                string value = TrainsheetGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() ?? "";

                switch (e.ColumnIndex)
                {
                    case 0:
                        if (!IsDigit(value))
                        {
                            MessageBox.Show("Номер поезда это число", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TrainsheetGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "1";
                        }
                        break;

                    case 2:
                        if (!IsTime(value))
                        {
                            MessageBox.Show("Время отправления по формату 12:00", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            TrainsheetGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "12:00";
                        }
                        break;
                }
            }
        }

        private void Input_Number_TextChanged(object sender, EventArgs e) // Проверка что вводиться число
        {
            if (!IsDigit(Input_Txt.Text))
            {
                Input_Txt.Text = "1";
                MessageBox.Show("Необходим номер поезда(число)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Utility Functions

        private static bool IsDigit(string s) // Проверка что строка содержит только цифры
        {
            int i = 0;

            while (i < s.Length)
            {
                if (!char.IsDigit(s[i]))
                {
                    i = s.Length + 1;
                }

                i++;
            }

            return i == s.Length;
        }

        private static bool IsTime(string s) // Проверка времени по формату
        {
            return Regex.IsMatch(s, @"^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
        }

        private void ResetViews() // Востанавливает изначальное состояние элементов формы
        {
            About_Lbl.Visible = false;
            MultiBtn.Visible = false;
            TrainsheetGridView.Visible = false;
            Info_Lbl.Visible = false;
            Input_Txt.Visible = false;

            MultiBtn.Text = string.Empty;
            MultiBtn.Click -= Save_Click!;
            MultiBtn.Click -= AddFirst_Click!;
            MultiBtn.Click -= AddLast_Click!;
            MultiBtn.Click -= AddCustom_Click!;
            MultiBtn.Click -= DeleteCustom_Click!;
            MultiBtn.Click -= SetNumber_Click!;
            MultiBtn.Click -= SetName_Click!;

            Input_Txt.Text = string.Empty;
            Info_Lbl.Text = string.Empty;
            Input_Txt.TextChanged -= Input_Number_TextChanged!;

            TrainsheetGridView.Rows.Clear();
            TrainsheetGridView.ReadOnly = false;
        }

        private void SetColumns() // Устанавливает столбцы для таблицы
        {
            TrainsheetGridView.AllowUserToAddRows = true;

            TrainsheetGridView.ColumnCount = 3;

            TrainsheetGridView.Columns[0].HeaderText = "Номер поезда";
            TrainsheetGridView.Columns[1].HeaderText = "Станция назначения";
            TrainsheetGridView.Columns[2].HeaderText = "Время отправления";


            TrainsheetGridView.Columns[0].Width = 100;
            TrainsheetGridView.Columns[1].Width = 200;
            TrainsheetGridView.Columns[2].Width = 200;
        }

        private bool AlreadyExist(int trainNumber) // Проверяет наличия поезда в системе
        {
            return trainList.Search(trainNumber) != null;
        }

        #endregion
    }
}