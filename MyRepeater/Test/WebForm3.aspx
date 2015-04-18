<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Test.WebForm3" %>

<%@ Register Assembly="MyRepeater" Namespace="MyRepeater" TagPrefix="cc2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div> <ul>
    <cc2:MyRepeater3 ID="ServerControl1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
                <ItemTemplate>
                <li>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><%#Eval("name") %>
                </li>
            </ItemTemplate>
            </cc2:MyRepeater3></ul>
    </div>
    </form>
</body>
</html>