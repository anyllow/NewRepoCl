<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoggingApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form name="topic" action="comment.php" method="post">
  <p>
    <label>Новый раздел:</label>
    <br />
    <textarea name="text_comment" style="height: 41px; width: 1371px"></textarea>
  </p>
  <p>
    <input type="hidden" name="page_id" value="150" />
    <input type="submit" value="Отправить" />
  </p>
</form>
</body>
</html>
