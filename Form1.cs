using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p = 0; // Нажат ли был ранее Ctrl
        static int k = 5; // Кол-во ячеек в хранилище
        Storage storag = new Storage(k); // Создаем объект хранилища
        static int index = 0; // Кол-во нарисованных кругов
        int indexin = 0; // Индекс, в какое место был помещён круг
        int size = 0;

        class Figure
        {
            public int x, y;
            public bool is_drawed = true;
            public Color fillcolor = Color.Aqua;
            private Color color = Color.Black;

            public void setColor(Color color)
            {
                this.color = color;
            }
            public Color getColor()
            {
                return color;
            }
        }

        class Circle : Figure
        {
            public int rad = 30; // Радиус круга
            public Circle(int x, int y)
            {
                this.x = x - rad;
                this.y = y - rad;
            }

            ~Circle() { }
        }

        class Square : Figure
        {
            public int x2, y2, size = 60;
            public Square(int x, int y)
            {
                this.x = x - size / 2;
                this.y = y - size / 2;
                this.x2 = size;
                this.y2 = size;
            }

            ~Square() { }
        }

        class Line : Figure
        {
            public int lenght = 60, wight = 3, x2, y2;
            public Line(int x, int y)
            {
                this.x = x - lenght / 2;
                this.y = y;
                this.x2 = x + lenght;
                this.y2 = y;
            }
            ~Line() { }
        }

        class Storage
        {
            public Figure[] objects;

            public Storage(int count)
            {   // Конструктор по умолчанию 
                // Выделяем count мест в хранилище
                objects = new Figure[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void initialisat(int count)
            {   // Выделяем count мест в хранилище
                objects = new Figure[count];
                for (int i = 0; i < count; ++i)
                    objects[i] = null;
            }
            public void add_object(int ind, ref Figure object1, int count, ref int indexin)
            {   // Добавляет ячейку в хранилище
                // Если ячейка занята ищем свободное место
                while (objects[ind] != null)
                {
                    ind = (ind + 1) % count;
                }
                objects[ind] = object1;
                indexin = ind;
            }
            public void delete_object(int ind)
            {   // Удаляет объект из хранилища
                objects[ind] = null;
                index--;
            }

            public bool check_empty(int index)
            {   // Проверяет занято ли место хранилище
                if (objects[index] == null)
                    return true;
                else return false;
            }

            public int occupied(int size)
            { // Определяет кол-во занятых мест в хранилище
                int count_occupied = 0;
                for (int i = 0; i < size; ++i)
                    if (!check_empty(i))
                        ++count_occupied;
                return count_occupied;
            }

            public void doubleSize(ref int size)
            {   // Функция для увеличения кол-ва элементов в хранилище в 2 раза 
                Storage storage1 = new Storage(size * 2);
                for (int i = 0; i < size; ++i)
                    storage1.objects[i] = objects[i];
                for (int i = size; i < (size * 2) - 1; ++i)
                {
                    storage1.objects[i] = null;
                }
                size = size * 2;
                initialisat(size);
                for (int i = 0; i < size; ++i)
                    objects[i] = storage1.objects[i];
            }

            ~Storage() { }
        };

        private void paint_Figure(Color name, ref Storage stg, int index)
        {
            Pen pen = new Pen(name, 3);
            SolidBrush figurefillcolor;
            if (!storag.check_empty(index))
            {
                figurefillcolor = new SolidBrush(stg.objects[index].fillcolor);
                if (storag.objects[index] as Circle != null)
                {
                    Circle circle = storag.objects[index] as Circle;
                    PanelD.CreateGraphics().DrawEllipse(pen, circle.x, circle.y, circle.rad * 2, circle.rad * 2);
                    PanelD.CreateGraphics().FillEllipse(figurefillcolor, circle.x, circle.y, circle.rad * 2, circle.rad * 2);
                    stg.objects[index].setColor(name);
                }
                else
                {
                    if (storag.objects[index] as Square != null)
                    {
                        Square square = storag.objects[index] as Square;
                        PanelD.CreateGraphics().DrawRectangle(pen, square.x, square.y, square.x2, square.y2);
                        PanelD.CreateGraphics().FillRectangle(figurefillcolor, square.x, square.y, square.x2, square.y2);
                        stg.objects[index].setColor(name);
                    }
                    else
                    {
                        if (storag.objects[index] as Line != null)
                        {
                            Line line = storag.objects[index] as Line;
                            PanelD.CreateGraphics().DrawLine(pen, line.x - 1, line.y, line.x2 + 1, line.y2);
                            PanelD.CreateGraphics().FillRectangle(figurefillcolor, line.x, line.y, line.lenght + 30, line.wight);
                            stg.objects[index].setColor(name);
                        }
                    }
                }
            }
        }

        private void remove_selection_circle(ref Storage stg)
        {   // Снимает выделение у всех элементов хранилища
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    paint_Figure(Color.Black, ref storag, i);
                }
            }
        }

        private void remove_selected_circle(ref Storage stg)
        {   // Удаляет выделенные элементы из хранилища
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    if (storag.objects[i].getColor() == Color.Blue)
                    {
                        storag.delete_object(i);
                    }
                }
            }
        }

        private int check_figure(ref Storage stg, int size, int x, int y)
        {   // Проверяет есть ли уже фигура с такими же координатами в хранилище
            if (stg.occupied(size) != 0)
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!stg.check_empty(i))
                    {   // Если под i индексом в хранилище есть объект
                        if (stg.objects[i] as Circle != null)
                        {   // Если в хранилище круг
                            Circle circle = stg.objects[i] as Circle;
                            if (((x - circle.x - circle.rad) * (x - circle.x - circle.rad) +
                                (y - circle.y - circle.rad) * (y - circle.y - circle.rad))
                                < (circle.rad * circle.rad))
                                return i;
                        }
                        else
                        {
                            if (stg.objects[i] as Line != null)
                            {   // Если в хранилище отрезок
                                Line line = stg.objects[i] as Line;
                                if (line.x <= x && x <= (line.x + line.lenght) && (line.y - 2) <= y &&
                                    y <= (line.y + line.wight))
                                    return i;
                            }
                            else
                            {
                                if (stg.objects[i] as Square != null)
                                {   // Если в хранилище квадрат
                                    Square square = stg.objects[i] as Square;
                                    if (square.x <= x && x <= (square.x + square.size) &&
                                        square.y <= y && y <= (square.y + square.size))
                                        return i;
                                }
                            }
                        }

                    }
                }
            }
            return -1;
        }

        private void ClearB_Click(object sender, EventArgs e)
        {   // Очищает панель от кругов
            PanelD.Refresh(); // Перерисовывем панель PanelD

            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {   // Меняем is_drawed на false
                    storag.objects[i].is_drawed = false;
                }
            }
        }

        private void ExitB_Click(object sender, EventArgs e)
        {   // Отобразить все круги из хранилища
            PanelD.Refresh();
            if (storag.occupied(k) != 0)
            {

                for (int i = 0; i < k; ++i)
                {
                    if (!storag.check_empty(i))
                    {   // Меняем is_drawed на true
                        storag.objects[i].is_drawed = true;
                    }
                    paint_Figure(Color.Aqua, ref storag, i);
                }
            }

        }

        private void ClearstB_Click(object sender, EventArgs e)
        {   // Удалить все круги из хранилища
            for (int i = 0; i < k; ++i)
            {
                storag.objects[i] = null;
            }
            index = 0;
        }

        private void PanelD_MouseClick(object sender, MouseEventArgs e)
        {
            //Проверка на наличие круга на данных координатах
            int c = check_figure(ref storag, k, e.X, e.Y);
            if (index == k)
                storag.doubleSize(ref k);
            if (c != -1)
            {   // Если на этом месте уже нарисован круг
                if (Control.ModifierKeys == Keys.Control)
                {   // Если нажат ctrl, то выделяем несколько объектов
                    if (p == 0)
                    {
                        paint_Figure(Color.Black, ref storag, indexin);
                        p = 1;
                    }
                    // Вызываем функцию отрисовки круга                            
                    paint_Figure(Color.White, ref storag, c);
                }
                else
                {   // Иначе выделяем только один объект
                    // Снимаем выделение у всех объектов хранилища
                    remove_selection_circle(ref storag);
                    // Вызываем функцию отрисовки круга                   
                    // Вызываем функцию отрисовки круга                          
                    paint_Figure(Color.White, ref storag, c);
                }
                return;
            }

            else
            {
                if (CircleRB.Checked == true)
                {
                    Figure krug = new Circle(e.X, e.Y);// Добавляем круг в хранилище                    
                    storag.add_object(index, ref krug, k, ref indexin); // Снимаем выделение у всех объектов хранилища
                    remove_selection_circle(ref storag); // Вызываем функцию отрисовки круга
                    storag.objects[indexin].fillcolor = Color.Aqua;
                    paint_Figure(Color.Black, ref storag, indexin);
                    ++index;
                }
                else
                {
                    if (SquareRB.Checked == true)
                    {
                        Figure kvadrat = new Square(e.X, e.Y);
                        storag.add_object(index, ref kvadrat, k, ref indexin);
                        remove_selection_circle(ref storag);
                        storag.objects[indexin].fillcolor = Color.Aqua;
                        paint_Figure(Color.Black, ref storag, indexin);
                        ++index;
                    }
                    else
                    {
                        if (LineRB.Checked == true)
                        {
                            Figure liniya = new Line(e.X, e.Y);
                            storag.add_object(index, ref liniya, k, ref indexin);
                            remove_selection_circle(ref storag);
                            storag.objects[indexin].fillcolor = Color.Aqua;
                            paint_Figure(Color.Black, ref storag, indexin);
                            ++index;
                        }
                    }
                }
            }
            p = 0;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {   // Удаление выделенных фигур, если нажата кнопка delete
                remove_selected_circle(ref storag);
            }
            if (e.KeyCode == Keys.W)
            {   // Перемещение по оси X вверх
                move_y(ref storag, -10);
            }
            if (e.KeyCode == Keys.S)
            {   // Перемещение по оси X вниз
                move_y(ref storag, +10);
            }
            if (e.KeyCode == Keys.A)
            {   // Перемещение по оси Y вниз
                move_x(ref storag, -10);
            }
            if (e.KeyCode == Keys.D)
            {   // Перемещение по оси Y вверх
                move_x(ref storag, +10);
            }
            PanelD.Refresh();
            paint_all(ref storag);
        }

        private void PinkRB_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    if (storag.objects[i].getColor() == Color.White)
                    {
                        storag.objects[i].fillcolor = Color.Aqua;
                        paint_Figure(Color.Black, ref storag, i);
                    }
                }
            }
        }

        private void MaroonRB_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                    if (storag.objects[i].getColor() == Color.White)
                    {
                        storag.objects[i].fillcolor = Color.Green;
                        paint_Figure(Color.Black, ref storag, i);
                    }
            }
        }

        private void PurpleRB_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < k; ++i)
            {
                if (!storag.check_empty(i))
                {
                    if (storag.objects[i].getColor() == Color.White)
                    {
                        storag.objects[i].fillcolor = Color.Red;
                        paint_Figure(Color.Black, ref storag, i);
                    }
                }
            }
        }

        private void paint_all(ref Storage stg)
        {   // Рисует все фигуры на панели
            for (int i = 0; i < k; ++i)
                if (!stg.check_empty(i))
                    paint_Figure(stg.objects[i].getColor(), ref storag, i);
        }

        private void move_y(ref Storage stg, int y)
        {   // Функция для перемещения фигур по оси Y
            for (int i = 0; i < k; ++i)
            {
                if (!stg.check_empty(i))
                {
                    if (stg.objects[i].getColor() == Color.White)
                    {   // Если объект выделен
                        if (stg.objects[i] as Circle != null)
                        {   // Если в хранилище круг
                            Circle circle = stg.objects[i] as Circle;
                            int c = circle.y + y;
                            int gran = PanelD.ClientSize.Height - circle.rad * 2;
                            // Проверяем на выход из границы поля
                            check(c, y, gran, gran - 2, ref stg.objects[i], 2);
                        }
                        else
                        {
                            if (stg.objects[i] as Line != null)
                            {   // Если в хранилище отрезок
                                Line line = stg.objects[i] as Line;
                                int l = line.y + y;
                                int gran = PanelD.ClientSize.Height - line.wight;
                                // Проверяем на выход из границы поля
                                check(l, y, gran, --gran, ref stg.objects[i], 2);
                            }
                            else
                            {
                                if (stg.objects[i] as Square != null)
                                {   // Если в хранилище квадрат
                                    Square square = stg.objects[i] as Square;
                                    int s = square.y + y;
                                    int gran = PanelD.ClientSize.Height - square.size;
                                    // Проверяем на выход из границы поля
                                    check(s, y, gran, --gran, ref stg.objects[i], 2);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void move_x(ref Storage stg, int x)
        {   // Функция для перемещения фигур по оси X
            for (int i = 0; i < k; ++i)
            {
                if (!stg.check_empty(i))
                {
                    if (stg.objects[i].getColor() == Color.White)
                    {   // Если объект выделен
                        if (stg.objects[i] as Circle != null)
                        {   // Если в хранилище круг
                            Circle circle = stg.objects[i] as Circle;
                            int c = circle.x + x;
                            int gran = PanelD.ClientSize.Width - (circle.rad * 2);
                            // Проверяем на выход из границы поля
                            check(c, x, gran, gran - 2, ref stg.objects[i], 1);
                        }
                        else
                        {
                            if (stg.objects[i] as Line != null)
                            {   // Если в хранилище отрезок
                                Line line = stg.objects[i] as Line;
                                int l = line.x + x;
                                int gran = PanelD.ClientSize.Width - line.lenght;
                                // Проверяем на выход из границы поля
                                check(l, x, gran, --gran, ref stg.objects[i], 1);
                            }
                            else
                            {
                                if (stg.objects[i] as Square != null)
                                {   // Если в хранилище квадрат
                                    Square square = stg.objects[i] as Square;
                                    int s = square.x + x;
                                    int gran = PanelD.ClientSize.Width - square.size;
                                    // Проверяем на выход из границы поля
                                    check(s, x, gran, --gran, ref stg.objects[i], 1);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void check(int f, int y, int gran, int gran1, ref Figure figures, int g)
        {   // Проверка на выход фигуры за границы
            ref int b = ref figures.x;
            if (g == 2)
                b = ref figures.y;
            if (f > 0 && f < gran)
                b += y;
            else
            {
                if (f <= 0)
                    b = 1;
                else
                    if (f >= gran1)
                    b = gran1;
            }
        }

        private void changesize(ref Storage stg, int size)
        {   // Увеличивает или уменьшает размер фигур, в зависимости от size
            for (int i = 0; i < k; ++i)
            {
                if (!stg.check_empty(i))
                {   // Если под i индексом в хранилище есть объект
                    if (stg.objects[i].getColor() == Color.White)
                    {
                        if (stg.objects[i] as Circle != null)
                        {   // Если в хранилище круг
                            Circle circle = stg.objects[i] as Circle;
                            circle.rad += size;
                        }
                        else
                        {
                            if (stg.objects[i] as Line != null)
                            {   // Если в хранилище отрезок
                                Line line = stg.objects[i] as Line;
                                line.lenght += size;
                                line.x2 += size;
                            }
                            else
                            {
                                if (stg.objects[i] as Square != null)
                                {   // Если в хранилище квадрат
                                    Square square = stg.objects[i] as Square;
                                    square.size += size;
                                    square.x2 = square.size;
                                    square.y2 = square.size;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
