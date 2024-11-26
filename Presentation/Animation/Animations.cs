using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Presentation.Animation
{
    public class Animations
    {
       
        private int _animationStep = 10;
        private bool _sidebarExpanded;
       
     

        public void ViewSideTransition(System.Windows.Forms.Timer timer, Panel AdminPanel, bool sidebarExpanded)
        {
            timer.Tick += (sender, e) =>
            {
                if (sidebarExpanded)
                {
                    AdminPanel.Width -= _animationStep;
                    if (AdminPanel.Width <= 10)
                    {
                        sidebarExpanded = false;
                        timer.Stop();

                    }
                }
                else
                {
                    AdminPanel.Width += _animationStep;
                    if (AdminPanel.Width >= 283)
                    {
                        sidebarExpanded = true;
                        timer.Stop();
                    }
                }
            };



        }


        public void SideBooksTransition(System.Windows.Forms.Timer timer, Panel BooksPanel, bool sidebarExpanded)
        {
            timer.Tick += (sender, e) =>
            {
                if (sidebarExpanded)
                {
                    BooksPanel.Width -= _animationStep;
                    if (BooksPanel.Width <= 50 )
                    {
                        sidebarExpanded = false;
                        timer.Stop();

                    }
                }
                else
                {
                    BooksPanel.Width += _animationStep;
                    if (BooksPanel.Width >=246)
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

        public void SideUserTransition(System.Windows.Forms.Timer timer, Panel StudentPanel, bool sidebarExpanded)
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
                    if (StudentPanel.Width >= 246)
                    {
                        sidebarExpanded = true;
                        timer.Stop();
                    }
                }
            };



        }
    }
}
