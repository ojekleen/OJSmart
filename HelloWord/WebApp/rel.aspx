<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rel.aspx.cs" Inherits="WebApp.rel" culture="auto"  uiculture="auto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <div>
       <header ></header>
       <ul>
           <li>中文内容1</li>
           <li>2</li>
           <li>3</li>
           <li>4</li>
           <li>5</li>
       </ul>
   </div>

    <asp:Label runat="server" ID="l1" Text="<%$ Resources:ResEn, header1 %>"></asp:Label>
</body>
</html>
