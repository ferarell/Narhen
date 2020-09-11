Imports DevExpress.XtraEditors.DXErrorProvider

Public Class CustomValidationRule
    Inherits ValidationRule

    Public Overrides Function Validate(ByVal control As Control, ByVal value As Object) As Boolean
        Dim res As Boolean = False
        If IsDBNull(value) Then
            Return res
        End If
        Dim str As String = CStr(value)
        If Not String.IsNullOrEmpty(str) Then
            If Not String.IsNullOrEmpty(str.Trim()) Then
                res = True
            End If
        End If
        'Dim values() As String = {"Dr.", "Mr.", "Mrs.", "Miss", "Ms."}
        'Dim res As Boolean = False
        'Dim val As String
        'For Each val In values
        '    If ValidationHelper.Validate(str, ConditionOperator.BeginsWith, _
        '        val, Nothing, Nothing, False) Then
        '        Dim name As String = str.Substring(val.Length)
        '        If name.Trim().Length > 0 Then
        '            res = True
        '        End If
        '    End If
        'Next val
        Return res
    End Function
End Class


