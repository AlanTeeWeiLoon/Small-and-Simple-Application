function chinese_zodiac() {
var year= document.getElementById('txtbirthday').value;
if(!year){
alert("Please enter your birthday year");
}
else if(year.length!=4){
alert("Please enter a valid year");
}
else{
    switch ((year - 4) % 12) {
        case 0:
            document.getElementById('txtanswer').value='Rat';
break;

        case 1:
            document.getElementById('txtanswer').value='Ox';
break;
        case 2:
            document.getElementById('txtanswer').value='Tiger';
break;
        case 3:
            document.getElementById('txtanswer').value='Rabbit';
break;
        case 4:
            document.getElementById('txtanswer').value='Dragon';
break;
        case 5:
            document.getElementById('txtanswer').value='Snake';
break;
        case 6:
            document.getElementById('txtanswer').value='Horse';
break;
        case 7:
           document.getElementById('txtanswer').value='Goat';
break;
        case 8:
            document.getElementById('txtanswer').value='Monkey';
break;
        case 9:
            document.getElementById('txtanswer').value='Rooster';
break;
        case 10:
           document.getElementById('txtanswer').value='Dog';
break;
        case 11:
            document.getElementById('txtanswer').value='Pig';
break;
    }
}
}

function register() {

      var name = document.getElementById("name").value;
      var email = document.getElementById("email").value;
      var phone = document.getElementById("phone").value;
	var country = document.getElementById("country").value;
var getgender = document.querySelector( 'input[name="gender"]:checked');  
      var username = document.getElementById("username").value;
      var password = document.getElementById("password").value;
      var cpassword = document.getElementById("cpassword").value;

      if(name.length == 0){
            alert("Name: Please Enter Full Name");
            return false;
          }
if(email.indexOf("@") == -1 || email.length < 6){
              alert("Email: Please Enter valid Email that included '@'");
            return false;
          }

            
            if(isNaN(phone)|| phone.length!=10)
           {
              alert("Phone: Please Enter valid phone number with 10 digits");
              return false; 
           }

          
          
if(!country){
            alert("Country: Please Select a country");
            return false;
          }
if(!getgender){
            alert("Gender: Please Select your gender");
            return false;
          }
if(!username){
            alert("Username: Please enter your username");
            return false;
          }
            
          if(password.length < 6 || password.length > 8){
              alert("Password: Please Enter a password with 6 to 8 characters");
            return false;
          }
if(cpassword!=password){
              alert("Confirm Password: Please confirm your password again!");
            return false;
          }
          window.alert("Registration success!");
          return true;
    }

function reset() {

      document.getElementById("name").value = "";
      document.getElementById("email").value= "";
      document.getElementById("phone").value= "";
	document.getElementById("country").value= "";
document.querySelector( 'input[name="gender"]:checked')="";  
      document.getElementById("username").value= "";
      document.getElementById("password").value= "";
      document.getElementById("cpassword").value= "";
}

