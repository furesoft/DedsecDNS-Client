﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace DedSecDns_Client.Core.MVC
{
    public class AppManager
    {
        public static AppManager Instance
        {
            get
            {
                if (!_started)
                    throw new Exception("Tried to call the singleton instance of the AppManager before the AppManager started.");

                return _instance;
            }
        }

        /// <summary>
        /// Starts the AppManager and creates a singleton for this class
        /// </summary>
        public static void Start<T>()
            where T : Controller
        {
            if (_started) return;

            _started = true;

            T controller = Activator.CreateInstance<T>();

            if (controller != null)
            {
                _instance = new AppManager()
                {
                    _currentView = controller.View
                };

                _instance.openForm();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Loads a Controller, handles the loading state
        /// </summary>
        /// <typeparam name="T">Generic Type where T extends Controller</typeparam>
        public void Load<T>()
            where T : Controller
        {
            T controller = Activator.CreateInstance<T>();

            if (controller != null)
            {
                if (controller.Loadable())
                {
                    controller.OnLoadSuccess(EventArgs.Empty);
                }
                else
                {
                    controller.OnLoadFailure(EventArgs.Empty);
                }
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Shows the View of the Controller parameter
        /// </summary>
        /// <param name="controller">The controller instance</param>
        public void Show(Controller controller)
        {
            if (_currentView != null)
            {
                _currentView.Close();
                _currentView.Form.Dispose();
            }

            _currentView = controller.View;

            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        public void ShowDialog(Controller controller)
        {
            var oldview = _currentView;
            _currentView = controller.View;
            controller.View.Form.FormClosing += (s, e) => _currentView = oldview;
            Thread th = new Thread(openForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private static AppManager _instance;
        private static bool _started;

        /// <summary>
        /// The current WinForms-Form instance
        /// </summary>
        private IView _currentView;

        /// <summary>
        /// Private constructor to prevent instantiation
        /// </summary>
        private AppManager() { }

        /// <summary>
        /// Used as single-threaded appartment thread-callback to keep the main thread running
        /// </summary>
        private void openForm()
        {
            Application.Run(_currentView.Form);
        }
    }
}