# UDEMY-GITHUB-ACTIONS

Un proyecto práctico de GitHub Actions y Workflows diseñado para explorar y dominar las capacidades de CI/CD (Integración Continua y Despliegue Continuo) utilizando GitHub Actions.

## 🚀 Empezando
Estas instrucciones te ayudarán a configurar tu proyecto y a ejecutarlo en tu máquina local para propósitos de desarrollo y pruebas. Ve a la sección Instalación para saber cómo desplegar el proyecto.


## 🔧 Instalación
Las acciones dependen de algunas variables que tendremos que configurar para que el comportamiento sea el esperado

`[url-repositorio]/settings/variables/actions/new`

| Name                 | Value | Descripcion |
| -------------------- | ----- |-------------|
| `ACTIONS_RUNNER_DEBUG` | `true` |Contain information about how a runner is executing a job|
| `ACTIONS_STEP_DEBUG`   | `true` |Step debug logging increases the verbosity of a job's logs during and after a job's execution|

## 📁 .github/workflows

Los workflows están en el directorio `.github/workflows`. 

Se incluyen varios archivos de configuración de GitHub Actions que demuestran distintos aspectos y capacidades de las GitHub Actions y Workflows. 

*Los workflows están desabilitados manualmente, tendrás que habilitarlos para poder probar.*

A continuación se detalla la función y características principales de cada archivo YAML proporcionado:

## 🚫 01-first-workflow.yaml 
### Deshabilitado manualmente
Este workflow muestra dos pasos que se ejecutan en paralelo

> 1.  `run-shell-command` -> `dependant-job` *(se ejecuta a solo cuando termina run-shell-command)*

> 2.  `parallel-job-macos`


## 🚫 02-workflow-commands.yaml
Ejecuta un único paso en el que se muestran los resultados en diferentes formatos: 
- Error
- Warning
- Notice
- Agrupación de los mensajes

> `testing-wf-commands`


## 🚫 03-working-dir-and-shells.yaml

Este workflow muestra dos pasos que se ejecutan en secuencia

> 1.  `display-wd-info` *comandos y variables ubuntu-latest*

> 2.  `display-wd-info-windows` *comandos y variables windows-latest*



## 🚫 04-working-dir-and-using-default-shell.yaml 

Similar al anterior, este workflow muestra dos pasos que se ejecutan en secuencia.
Se establece el shell por defecto para todo el workflow y para cada step

> 1.  `display-wd-info` *comandos y variables ubuntu-latest*

> 2.  `display-wd-info-windows` *comandos y variables windows-latest / python*


## 🚫 05-simple-action.yaml

Este workflow llama un `Action` entre sus steps, los `Action` ejecutan tareas mas complejas que solo ejecutar un comando como en los ejemplos anteriores.

Un `Action` es una unidad de codigo reutilizable que referenciamos en nuestros steps.

En este caso usamos `actions/hello-world-javascript-action@v1` que está deprecated, de ahí que nos salgan algunos warnings en la ejecución del workflow. 

*Colocamos la ruta del action que queremos ejecutar y despues del @ ponemos la rama, tag o commit que queremos ejecutar, la version (tag)*


## 🚫 06-checkout.yaml

En este ejemplo hacemos el **Checkout** de dos formas:

> 1.  `checkout-action` *Hace el checkout por medio de un **Action**.*

> 2.  `checkout-and-display-files` *En este paso el checkout se hace de manera "Manual".*


## 🚫 07-events.yaml

Este workflow se dispara en tres eventos: `push, pull_request, issues`

> `checkout-test` *Hace el checkout por medio de un **Action**.*


## 🎁 Expresiones de Gratitud
- Comenta a otros sobre este proyecto 📢
- Invita una cerveza 🍺 o un café ☕ a alguien del equipo.
- Da las gracias públicamente 🤓.
- etc.