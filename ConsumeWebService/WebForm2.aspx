<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ConsumeWebService.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <table style="font-family:Arial">
          <tr>
              <td>
                 <b>First Number</b>                 
              </td>
              <td>
                   <asp:TextBox ID="TxtFirst" runat="server"></asp:TextBox>
              </td>
                </tr>

          <tr>
              <td>
                  <b>Second Number </b>
              </td>
              <td>
                  <asp:TextBox ID="TxtSecond" runat="server" ></asp:TextBox>
              </td>
           </tr>
          <tr>
              <td>
                  <b>Result</b>
              </td>
              <td>
                <asp:Label ID="LblMessage" runat="server"></asp:Label>
              </td>
          </tr>

          <tr>
              <td colspan="2">

                  <asp:Button ID="btnresult" runat="server" Text="Addition" OnClick="btnresult_Click" />

              </td>
                      </tr>
          <tr>

              <td>

                  <asp:GridView ID="Gridview1" runat="server" BorderColor="Red" BackColor="Yellow">

                  </asp:GridView>
              </td>
          </tr>


      </table>
    </form>
</body>
</html>
