<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConsumeWebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <table style="  font-family: Arial " >

          <tr>
              <td>
                  <b> Enter the FirstNumber:</b>
              </td>
              <td>
                  <asp:TextBox ID="TxtFirstNum" runat="server" ></asp:TextBox>
              </td>

                        </tr>
          <tr>
               <td>
                  <b> Enter the SecondNum:</b>
              </td>
              <td>
                  <asp:TextBox ID="TxtSecondNum" runat="server" ></asp:TextBox>
              </td>
               </tr>
          <tr>
              <td>
                  <b>Result</b>
              </td>
              <td>
                <asp:Label ID="lblresult" runat="server"> </asp:Label>
              </td>
                    </tr>

          <tr>
              <td colspan="2">
                <asp:Button ID="BtnAdd" runat="server" Text="ADD" OnClick="BtnAdd_Click" />
              </td>
          </tr>

      </table>
    </form>
</body>
</html>
