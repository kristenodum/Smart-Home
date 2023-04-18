﻿'Author: Kristen Odum
'Program Name: Smart Home Electric Savings Windows Application 
'Program Purpose: The smart home electric savings windows application uses a
'text file that contains the 12 months of electric bill savings after 
'the smart home devices were activated 

Option Strict On
Public Class frmSmartHome
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmBill_load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblSavings.Text = ""
        lblAverageSavings.Text = ""
        lblMaxSavings.Text = ""

        If IO.File.Exists("C:\VB\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\VB\Savings.txt")
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop

            objReader.Close()

            For intFill = 0 To (_strSavings.Length - 1)
                cboMonths.Items.Add(_strSavings(intFill))

            Next
        Else
            MsgBox("The file is not available. Restart the program when the file is available", , "Error")
            Close()
        End If

    End Sub

    Private Sub cboMonths_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonths.SelectedIndexChanged
        'The cboMonths displays the savings for the seleced months 
        Dim intSelectedCityIndex As Integer


        intSelectedCityIndex = cboMonths.SelectedIndex
        lblSavings.Text = "The electric savings for " & _strSavings(intSelectedCityIndex) & " is $" & _decBill(intSelectedCityIndex).ToString()
        btnStatistics.Visible = True
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        'The btnStatistics click will calls two sub methods to compute the average monthly savings and 
        'the most savings for a given month 
        ComputeAverage()
        ComputeMaxSavings()

    End Sub
    Private Sub ComputeMaxSavings()
        'The ComputeMaxSavings Sub method will determine the month with the most savings 
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblMaxSavings.Text = strYearValue & " had the most significant month savings"
    End Sub
    Private Sub ComputeAverage()
        'The ComputeAverage Sub Method will compute the average number of electric bill savings of Bill 
        'in the years from 2000-2017

        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBills = 0D

        For Each intCountYears In _decBill
            decTotalBill += _decBill(intYears)
            intYears += 1
        Next
        decAverageNumberOfBills = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverageSavings.Text = "The average monthly savings: " & decAverageNumberOfBills.ToString("C2")

    End Sub
End Class
