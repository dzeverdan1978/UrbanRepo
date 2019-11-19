<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 239px;
        }
    </style>
</head>
<script language="javascript">
    function Vidljivo()
     {
        document.getElementById("uputstvo").style.visibility="visible";
    }
    function Nevidljivo()
    {
        document.getElementById("uputstvo").style.visibility="hidden";
    }
    
</script>
<body>
    <form id="form1" runat="server">
    
        <table cellspacing=20>
        <tr>
        <td class="style1">
        <div align=left>
        <img src="Grb-grada-250x300pix.jpg" style="height: 130px; width: 111px" />
        </div>
        </td>
        <td align=center>
        <h3>ODELJENJE ZA DOKUMENTACIJU</h3>
        <h5>Pretraga uz pomoć kartografskog broja</h5>
        <span id="uputstvo" style="color:Red; visibility:hidden">Ukucajte kartografski broj predmeta i pritisnite taster ENTER</span>
        </td>
        </tr>
        </table>
        <div align="center">
        <hr /><br />
        <div onmouseover="Vidljivo()" onmouseout="Nevidljivo()">
        <strong>Kartografski broj:</strong>
        <asp:TextBox ID="txtLart" runat="server" AutoPostBack="true" OnLoad="txtLart_Load" OnTextChanged="txtLart_TextChanged" /> 
        </div>
        <br /><hr /><br />
        <asp:Literal ID="lit" runat="server" />
    </div>
    </form>
</body>
</html>
