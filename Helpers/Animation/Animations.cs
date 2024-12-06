using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Helpers.Animation
{
    public class Animations
    {

        private int _animationStep;
        private bool _sidebarExpanded;
       
        public Animations(int animationStep = 10)
        {
            this._animationStep = animationStep;
            this._sidebarExpanded = false;

        }

        public void LoadForm(Panel mainPanel, Form newForm)
        {
            if (mainPanel.Controls.Count > 0) mainPanel.Controls.Clear();

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(newForm);
            mainPanel.Tag = newForm;
            newForm.Show();
        }

        public void ViewSideProfile(System.Windows.Forms.Timer timer, Panel panel, int collapsedWidth, int expandedWidth)
        {
            timer.Tick += (sender, e) =>
            {
                if (_sidebarExpanded)
                {
                    panel.Width -= _animationStep;
                    if (panel.Width <= collapsedWidth)
                    {
                        panel.Width = collapsedWidth;
                        _sidebarExpanded = false;
                        timer.Stop();
                    }
                }
                else
                {
                    panel.Width += _animationStep;
                    if (panel.Width >= expandedWidth)
                    {
                        panel.Width = expandedWidth;
                        _sidebarExpanded = true;
                        timer.Stop();
                    }
                }
            };
            timer.Start();
        }

        public void SideBooksTransition(System.Windows.Forms.Timer timer, Panel BooksPanel, bool sidebarExpanded)
        {
            timer.Tick += (sender, e) =>
            {
                if (sidebarExpanded)
                {
                    BooksPanel.Width -= _animationStep;
                    if (BooksPanel.Width <= 50)
                    {
                        sidebarExpanded = false;
                        timer.Stop();

                    }
                }
                else
                {
                    BooksPanel.Width += _animationStep;
                    if (BooksPanel.Width >= 246)
                    {
                        sidebarExpanded = true;
                        timer.Stop();
                    }
                }
            };



        }


        public void CrudBooksTransition(System.Windows.Forms.Timer timer, Panel BooksPanel, bool sidebarExpanded)
        {
            timer.Tick += (sender, e) =>
            {
                if (sidebarExpanded)
                {
                    BooksPanel.Width -= _animationStep;
                    if (BooksPanel.Width <= 263)
                    {
                        sidebarExpanded = false;
                        timer.Stop();

                    }
                }
                else
                {
                    BooksPanel.Width += _animationStep;
                    if (BooksPanel.Width >= 1092)
                    {
                        sidebarExpanded = true;
                        timer.Stop();
                    }
                }
            };

        }

        public void OpenCrudTransition(System.Windows.Forms.Timer timer, Panel StudentPanel, bool sidebarExpanded)
        {
            timer.Tick += (sender, e) =>
            {
                if (sidebarExpanded)
                {
                    StudentPanel.Width -= _animationStep;
                    if (StudentPanel.Width <= 50)
                    {
                        sidebarExpanded = false;
                        timer.Stop();

                    }
                }
                else
                {
                    StudentPanel.Width += _animationStep;
                    if (StudentPanel.Width >= 287)
                    {
                        sidebarExpanded = true;
                        timer.Stop();
                    }
                }
            };



        }

        public void CrudStudentTransition(System.Windows.Forms.Timer timer, Panel StudentPanel, bool sidebarExpanded)
        {
            timer.Tick += (sender, e) =>
            {
                if (sidebarExpanded)
                {
                    StudentPanel.Width -= _animationStep;
                    if (StudentPanel.Width <= 263)
                    {
                        sidebarExpanded = false;
                        timer.Stop();

                    }
                }
                else
                {
                    StudentPanel.Width += _animationStep;
                    if (StudentPanel.Width >= 1092)
                    {
                        sidebarExpanded = true;
                        timer.Stop();
                    }
                }
            };

        }

        
    }
}
