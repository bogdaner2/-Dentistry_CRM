﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dentistry_CRM.ViewModels;

namespace Dentistry_CRM.Views
{
    /// <summary>
    /// Interaction logic for SettingsView.xaml
    /// </summary>
    public partial class SettingsView : Page
    {
        public SettingsViewModel VM { get; set; }

        public SettingsView()
        {
            InitializeComponent();
            VM = new SettingsViewModel();
            DataContext = VM;
            IP.Text = "IP адреса робочого компьютера :" + VM.GetLocalIPAddress();
        }
    }
}
