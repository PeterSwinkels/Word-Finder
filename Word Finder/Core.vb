'This module's imports and settings.
Option Compare Binary
Option Explicit On
Option Infer Off
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Environment
Imports System.Linq

'This module contains this program's core procedures.
Public Module CoreModule
   Private ReadOnly LETTER_FILTER() As Char = "abc".ToLower().ToCharArray()   'Contains the list of letters of which a given minimum number should be present in a word.
   Private Const MAXIMUM_WORD_LENGTH As Integer = 5                     'Defines the longest word allowed.
   Private Const MINIMUM_NUMBER_OF_MATCHING_LETTERS As Integer = 3      'Defines the minimum number of matching letters should be present in a word.

   'This procedure is executed when this program is started.
   Public Sub Main()
      Dim Words As New List(Of String)(My.Resources.Words.Split(NewLine.ToCharArray()).Distinct())
      Dim MatchingWords As New List(Of String)(From Word In Words Where Word.ToLower().ToCharArray().Intersect(LETTER_FILTER).Count >= MINIMUM_NUMBER_OF_MATCHING_LETTERS AndAlso Word.Length <= MAXIMUM_WORD_LENGTH)

      MatchingWords.ForEach(AddressOf Console.WriteLine)
   End Sub

End Module
