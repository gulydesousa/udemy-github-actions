// Ejemplo 1: Vulnerabilidad de XSS (Cross-Site Scripting)
function showAlert(message) {
    document.getElementById('alert').innerHTML = '<p>' + message + '</p>';
}

// Ejemplo 2: Uso de una contraseña débil
function authenticateUser(username, password) {
    if (password === '12345') {
        console.log('¡Inicio de sesión exitoso para el usuario ' + username + '!');
    } else {
        console.log('Error: Contraseña incorrecta');
    }
}

// Ejemplo 3: Vulnerabilidad de deserialización no segura
function processUserData(data) {
    var userData = JSON.parse(data);
    if (userData.isAdmin) {
        console.log('El usuario es un administrador');
    }
}

// Ejemplo 4: Vulnerabilidad de manipulación de URL
function redirect(redirectUrl) {
    window.location.href = redirectUrl;
}

//Ejemplo 5
function processUserData(data) {
    var user = JSON.parse(data);

    // Ejemplo de vulnerabilidad: División por cero
    var result = 10 / user.age;

    console.log('Resultado de la operación: ' + result);
}


function showMessage(message) {
    var div = document.createElement('div');
    div.innerHTML = message;
    document.body.appendChild(div);
}

//************************
alert('1');
