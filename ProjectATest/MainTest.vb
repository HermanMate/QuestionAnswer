Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class MainTest

    <TestMethod()> Public Sub AnswerTest()
        With New ProjectA.Main
            Assert.AreEqual(42, .Answer)
        End With
    End Sub

End Class