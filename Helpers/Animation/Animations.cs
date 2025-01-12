using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.Helpers.Animation
{
    public class Animations
    {
        private int _animationStep;
        private bool _sidebarExpanded;

        public Animations(int animationStep = 10)
        {
            _animationStep = animationStep;
            _sidebarExpanded = false;
        }

        public void LoadForm(Panel mainPanel, Form newForm)
        {
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.Clear();

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(newForm);
            mainPanel.Tag = newForm;
            newForm.Show();
        }

        public void TransitionPanelWidth(System.Windows.Forms.Timer timer, Panel panel, int collapsedWidth, int expandedWidth, bool isExpanded)
        {
            timer.Tick += (sender, e) =>
            {
                if (isExpanded)
                {
                    panel.Width -= _animationStep;
                    if (panel.Width <= collapsedWidth)
                    {
                        panel.Width = collapsedWidth;
                        isExpanded = false;
                        timer.Stop();
                    }
                }
                else
                {
                    panel.Width += _animationStep;
                    if (panel.Width >= expandedWidth)
                    {
                        panel.Width = expandedWidth;
                        isExpanded = true;
                        timer.Stop();
                    }
                }
            };
            timer.Start();
        }


        public void SideBooksTransition(System.Windows.Forms.Timer timer, Panel booksPanel, bool sidebarExpanded)
        {
            TransitionPanelWidth(timer, booksPanel, 50, 246, sidebarExpanded);
        }

        public void CrudBooksTransition(System.Windows.Forms.Timer timer, Panel booksPanel, bool sidebarExpanded)
        {
            TransitionPanelWidth(timer, booksPanel, 263, 881, sidebarExpanded);
        }

        public void OpenCrudTransition(System.Windows.Forms.Timer timer, Panel studentPanel)
        {
            TransitionPanelWidth(timer, studentPanel, 50, 287,  _sidebarExpanded);
        }

        public void CrudStudentTransition(System.Windows.Forms.Timer timer, Panel studentPanel, bool sidebarExpanded)
        {
            TransitionPanelWidth(timer, studentPanel, 52, 881, sidebarExpanded);
        }
    }
}
