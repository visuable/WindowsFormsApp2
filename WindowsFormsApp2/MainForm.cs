using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        // Создаем экземпляр класса второй формы.
        SecondForm form = new SecondForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenSecondFormButton_Click(Object sender, EventArgs e)
        {
            // Далее необходимо "привязать" метод-обработчик события.
            form.WordListBox.SelectedIndexChanged += WordListBox_SelectedIndexChanged;
            // Тогда все необходимые действия будут происходить именно в первой форме!
            // Далее открываем вторую форму в виде дочернего окна.
            form.ShowDialog(this);
        }

        private void WordListBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            // "((ListBox) sender)" называется явным приведением и необходимо, поскольку метод-обработчик находится в коде первой форме, а не во второй.
            // Переменная "sender" вызывается с таким типом, каким вызвало событие этого элемента. Например: если была нажата кнопка, то тип данных "sender" - Button.
            // В данном случае вызов осуществляется событием элемента ListBox, поэтому "sender" имеет тип ListBox. В противном случае, если явное преобразование будет неправильным, приложение выдаст исключение(ошибку).
            MessageBox.Show(((ListBox)sender).Text, "Вызов из первой формы!");
        }
    }
}
