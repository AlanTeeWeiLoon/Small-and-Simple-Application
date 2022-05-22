<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="csrf-token" content="{{ csrf_token() }}">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Real-Time Chat</title>
    <link rel="stylesheet" href="{{ asset('css/app.css') }}">
</head>
<body>
    <div class="container">
        <div class="row" id="app">
        <ul class="list-group offset-4 col-4" >
  <li class="list-group-item active" aria-current="true">Chat Room</li>
  <li class="list-group-item">A second item</li>
  <li class="list-group-item">A third item</li>
  <li class="list-group-item">A fourth item</li>
  <li class="list-group-item">And a fifth one</li>
  <input type="text" class="form-control" placeholder="Type your message here...">
</ul>
        </div>
    </div>
</body>
</html>