﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ColorControl
{
    class MessageForms
    {
        public enum FieldType
        {
            Text,
            Numeric,
            DropDown,
            Flags
        }

        public class FieldDefinition
        {
            public string Label { get; set; }
            public FieldType FieldType { get; set; } = FieldType.Text;
            public IEnumerable<string> Values { get; set; }
            public decimal MinValue { get; set; }
            public decimal MaxValue { get; set; }
            public object Value { get; set; }
        }

        public static Form MainForm;

        public static void WarningOk(string text)
        {
            MessageBox.Show(text, MainForm?.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ErrorOk(string text)
        {
            MessageBox.Show(text, MainForm?.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InfoOk(string text)
        {
            MessageBox.Show(text, MainForm?.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult QuestionYesNo(string text)
        {
            return MessageBox.Show(text, MainForm?.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static List<FieldDefinition> ShowDialog(string caption, IEnumerable<string> labels, Func<IEnumerable<FieldDefinition>, string> validateFunc = null)
        {
            var fieldDefinitions = labels.Select(l => new FieldDefinition
            {
                Label = l
            }).ToList();

            return ShowDialog(caption, fieldDefinitions, validateFunc);
        }

        public static List<FieldDefinition> ShowDialog(string caption, IEnumerable<FieldDefinition> fields, Func<IEnumerable<FieldDefinition>, string> validateFunc = null)
        {
            var values = new List<FieldDefinition>();

            var prompt = new Form()
            {
                Width = 500,
                Height = 90 + (fields.Count() * 55),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            var top = 10;
            var boxes = new List<Control>();

            foreach (var field in fields)
            {
                var label = field.Label;
                var textLabel = new Label() { Left = 40, Top = top, Text = label, AutoSize = true };
                top += 25;
                prompt.Controls.Add(textLabel);

                Control control;

                switch(field.FieldType)
                {
                    case FieldType.Text:
                        var textBox = new MaskedTextBox() { Left = 40, Top = top, Width = 400 };

                        if (label.Contains("Ip-address"))
                        {
                            textBox.Mask = "###.###.###.###";
                            textBox.ValidatingType = typeof(System.Net.IPAddress);
                            textBox.Culture = CultureInfo.InvariantCulture;
                        }
                        else if (label.Contains("MAC-address"))
                        {
                            textBox.Mask = "AA-AA-AA-AA-AA-AA";
                            textBox.Culture = CultureInfo.InvariantCulture;
                        }

                        control = textBox;
                        break;

                    case FieldType.Numeric:
                        var numericEdit = new NumericUpDown() { Left = 40, Top = top, Width = 400 };

                        if (field.MinValue != field.MaxValue)
                        {
                            numericEdit.Minimum = field.MinValue;
                            numericEdit.Maximum = field.MaxValue;
                        }

                        control = numericEdit;
                        break;

                    case FieldType.DropDown:
                        var comboBox = new ComboBox
                        {
                            Left = 40,
                            Top = top,
                            Width = 400,
                            DropDownStyle = ComboBoxStyle.DropDownList
                        };

                        if (field.Values != null && field.Values.Any())
                        {
                            comboBox.Items.AddRange(field.Values.ToArray());
                            comboBox.SelectedIndex = 0;
                        }

                        control = comboBox;
                        break;

                    case FieldType.Flags:
                        var checkedListBox = new CheckedListBox
                        {
                            Left = 40,
                            Top = top,
                            Width = 200,
                            Height = 100
                        };

                        top += 80;
                        prompt.Height += 80;

                        if (field.Values != null && field.Values.Any())
                        {
                            var compoundValue = (int)field.Value;
                            var enumValue = 1;
                            foreach (var value in field.Values)
                            {
                                var isChecked = (compoundValue & enumValue) == enumValue;

                                checkedListBox.Items.Add(value, isChecked);

                                enumValue *= 2;
                            }
                        }

                        control = checkedListBox;
                        break;

                    default:
                        continue;
                }

                top += 30;
                prompt.Controls.Add(control);
                boxes.Add(control);
                control.Tag = field;
            }

            var confirmation = new Button() { Text = "OK", Left = 365, Width = 75, Top = prompt.ClientRectangle.Height - 30 };
            confirmation.Click += (sender, e) =>
            {
                foreach (var box in boxes)
                {
                    var field = (FieldDefinition)box.Tag;

                    switch (field.FieldType)
                    {
                        case FieldType.Flags:
                            var checkedListBox = (CheckedListBox)box;

                            var compoundValue = 0;
                            var enumValue = 1;
                            for (var i = 0; i < checkedListBox.Items.Count; i++)
                            {
                                compoundValue += checkedListBox.GetItemChecked(i) ? enumValue : 0;
                                enumValue *= 2;
                            }

                            field.Value = compoundValue;
                            break;
                        default:
                            field.Value = box.Text.Trim();
                            break;
                    }
                }


                if (validateFunc != null)
                {
                    var message = validateFunc(fields);

                    if (!string.IsNullOrEmpty(message))
                    {
                        WarningOk(message);
                        return;
                    }
                }

                values.AddRange(fields);

                prompt.Close();
            };
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            prompt.ShowDialog(MainForm);

            return values;
        }

        public static Form ShowProgress(string caption)
        {
            var prompt = new Form()
            {
                Width = 300,
                Height = 100,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                ControlBox = false
            };
            var textLabel = new Label() { Left = 20, Top = 25, Text = caption, AutoSize = true };
            prompt.Controls.Add(textLabel);

            prompt.Show(MainForm);

            return prompt;
        }
    }
}