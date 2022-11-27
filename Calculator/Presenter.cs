namespace Calculator
{
    internal class Presenter
    {
        private View view;
        private Model model;

        public Presenter(View view, Model model)
        {
            this.view = view;
            this.model = model;
        }

        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                view.Print("Введите выражение. Для Выхода введите exit");
                string ans = view.ReadLine();
                if (!String.IsNullOrEmpty(ans))
                {
                    if (ans.Equals("exit"))
                    {
                        view.Print("Завершение работы приложения");
                        return;
                    }
                    else
                    {
                        model.SetText(ans);
                        string res = model.Execute();
                        view.Print("Результат: " + res);
                    }
                }
            }

        }
    }
}
