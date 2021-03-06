﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lumberjack_Cafeteria
{
    public partial class Form1 : Form
    {
        private readonly Queue<Lumberjack> _lumberjacks;
        private int _flapjackCounter = 0;

        public Form1()
        {
            InitializeComponent();
            _lumberjacks = new Queue<Lumberjack>();
        }

        public void RedrawForm()
        {
            // If there are no lumberjacks left
            if (_lumberjacks.Count == 0)
            {
                flapjackCountListBox.Items.Clear();
                breakfastLineListBox.Items.Clear();
                groupBox.Enabled = false;
                return;
            }

            groupBox.Enabled = true;

            // Redraws the breakfast line
            var lineOrder = 1;
            breakfastLineListBox.Items.Clear();
            foreach (var lumberjack in _lumberjacks)
            {
                breakfastLineListBox.Items.Add($"{lineOrder}. {lumberjack.Name}");
                lineOrder++;
            }

            // Redraws the flapjack counter
            var currentLumberjack = _lumberjacks.Peek();
            flapjackCountListBox.Items.Clear();
            if (_flapjackCounter > 0)
            {
                flapjackCountListBox.Items.Add($"{currentLumberjack.Name} has {_flapjackCounter} flapjacks.");
            }
        }

        private void AddLumberjackButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show(@"Please enter a name.", @"Cannot add lumberjack");
                return;
            }
            Lumberjack nextLumberjack = new Lumberjack(NameTextBox.Text);
            _lumberjacks.Enqueue(nextLumberjack);
            NameTextBox.Clear();
            RedrawForm();
        }

        private void addFlapjacksButton_Click(object sender, EventArgs e)
        {
            if (_lumberjacks.Count == 0)
                return;
            Flapjack food;
            if (crispyRadioButton.Checked)
                food = Flapjack.Crispy;
            else if (soggyRadioButton.Checked)
                food = Flapjack.Soggy;
            else if (brownedRadioButton.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            var nextLumberjack = _lumberjacks.Peek();
            nextLumberjack.TakeFlapjack(food, (int) numberOfFlapjacksNumericUpDown.Value);
            _flapjackCounter += (int) numberOfFlapjacksNumericUpDown.Value;
            RedrawForm();
        }

        private void nextLumberjackButton_Click(object sender, EventArgs e)
        {
            var currentLumberjack = _lumberjacks.Peek();
            currentLumberjack.EatFlapjacks();
            _lumberjacks.Dequeue();
            _flapjackCounter = 0;
            RedrawForm();
        }
    }
}
