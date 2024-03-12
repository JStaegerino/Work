Dim oDoc As Document = ThisDoc.Document

'set end of part on top
oDoc.ComponentDefinition.SetEndOfPartToTopOrBottom(True)
'will open the import-dialog and wait for imput
ThisApplication.CommandManager.ControlDefinitions.Item("AppImportFileCmd").Execute2(True)
'set end of part to bottom
oDoc.ComponentDefinition.SetEndOfPartToTopOrBottom(false)
