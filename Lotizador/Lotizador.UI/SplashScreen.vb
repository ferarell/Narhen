﻿Public Class SplashScreen
    Sub New()
        InitializeComponent()
        TextToSpeak("Iniciando Lotizador, espere por favor...")
        Me.labelControl1.Text = "Copyright © 1998-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum
End Class
