document
.querySelector('form')
.addEventListener('submit', function (e) {
  e.preventDefault();
  const name = document.querySelector('#user');
  const password = document.querySelector('#psswd');

  if (name.value === '') {
    name.style.border = "2px solid red";
    return false;
  } else {
    name.style.border = "2px solid green";
  }
  if (password.value === '') {
    password.style.border = "2px solid red";
    return false;
  } else {
    password.style.border = "2px solid green";
  }

  fetch(`connect.ajax.php`)
    .then(response => response.text())
    .then(data => {
     if(data === 'true'){
       alert('connecté !');
     } else {
       alert('Bad credentials');
     }

    });



});