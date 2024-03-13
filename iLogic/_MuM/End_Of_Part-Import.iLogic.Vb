Sub Main()
' Erstellt von: Jan Stäger
' Version: IV2024
' Datum: 13.03.2024
Const Version = "0.1"
' Changelog

' Beschreibung: Diese Regel versetzt das Bauteilende an den Anfang, um danach den Import-Dialog zu öffnen. 
' Sobald eine Datei ausgewählt wird, verschiebt sich das Bauteilende wieder ganz nach unten


Logger.Debug(iLogicVB.RuleName & " " & Version & " was just started ...")

If (ThisDoc.Document.DocumentType = DocumentTypeEnum.kPartDocumentObject) Then
	Logger.Debug("This document is a part document.")
Else
	Logger.Debug("Wrong document type. Has to be part document.")
	MessageBox.Show("Die Datei ist kein Bauteil", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
	Exit Sub
End If

Dim oDoc As Document = ThisDoc.Document

'set end of part on top
oDoc.ComponentDefinition.SetEndOfPartToTopOrBottom(True)

'will open the import-dialog and wait for imput
ThisApplication.CommandManager.ControlDefinitions.Item("AppImportFileCmd").Execute2(True)

'set end of part to bottom
oDoc.ComponentDefinition.SetEndOfPartToTopOrBottom(false)

Logger.Debug(iLogicVb.RuleName & " " & Version & "did finish.")

End Sub
