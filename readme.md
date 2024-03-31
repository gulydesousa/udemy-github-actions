# UDEMY-GITHUB-ACTIONS

Un proyecto práctico de GitHub Actions y Workflows diseñado para explorar y dominar las capacidades de CI/CD (Integración Continua y Despliegue Continuo) utilizando GitHub Actions.

## 🚀 Empezando

Sigue estas instrucciones para configurar y ejecutar el proyecto en tu máquina local para desarrollo y pruebas. Consulta la sección de Instalación para detalles sobre cómo configurar el entorno.

## 🔧 Instalación
Las acciones dependen de variables de entorno específicas para un comportamiento adecuado. Establece las siguientes variables en las configuraciones de tu repositorio:

`[url-repositorio]/settings/variables/actions/new`

| Name                 | Value | Descripcion |
| -------------------- | ----- |-------------|
| `ACTIONS_RUNNER_DEBUG` | `true` |Activa la información detallada durante la ejecución de los runners.|
| `ACTIONS_STEP_DEBUG`   | `true` |Aumenta la 'verbosity' de los registros para una depuración más detallada de los pasos.|

## 📁 .github/workflows

Encontrarás los workflows en el directorio `.github/workflows`. 
Estos archivos configuran distintos aspectos de GitHub Actions y demuestran su versatilidad.

> [!NOTE]
> Los workflows están desactivados manualmente. Deberás habilitarlos para ejecutar las pruebas.



## 🚫 01-first-workflow.yaml 
### Deshabilitado manualmente

Este workflow se ejecuta en dos trabajos paralelos. El primero (run-shell-command) debe completarse antes de que se ejecute el segundo (dependant-job). 

También hay un trabajo paralelo (parallel-job-macos) que se ejecuta en macOS.

> 1.  `run-shell-command` -> `dependant-job` *(se ejecuta a solo cuando termina run-shell-command)*

> 2.  `parallel-job-macos`


## 🚫 02-workflow-commands.yaml

Este archivo muestra cómo utilizar diferentes comandos para modificar la salida en los registros de ejecución de un workflow, tales como mostrar errores, advertencias, información y agrupar mensajes.

Ejecuta un único paso en el que se muestran los resultados en diferentes formatos: 
- Error
- Warning
- Notice
- Agrupación de los mensajes

> `testing-wf-commands`


## 🚫 03-working-dir-and-shells.yaml

Establece diferentes directorios de trabajo y shells en una máquina virtual Ubuntu y luego repite un proceso similar en Windows. Se utilizan comandos específicos para cada sistema operativo para mostrar la información del directorio.

Este workflow muestra dos pasos que se ejecutan en secuencia

> 1.  `display-wd-info` *comandos y variables ubuntu-latest*

> 2.  `display-wd-info-windows` *comandos y variables windows-latest*


## 🚫 04-working-dir-and-using-default-shell.yaml 

Similar al archivo anterior, pero además establece un shell predeterminado para todos los pasos en un entorno Ubuntu y luego para pasos individuales en un entorno Windows, incluyendo la utilización del shell de Python.

> 1.  `display-wd-info` *comandos y variables ubuntu-latest*

> 2.  `display-wd-info-windows` *comandos y variables windows-latest / python*


## 🚫 05-simple-action.yaml

Este workflow llama un `Action` entre sus steps, los `Action` ejecutan tareas mas complejas que solo ejecutar un comando como en los ejemplos anteriores.

Un `Action` es una unidad de codigo reutilizable que referenciamos en nuestros steps.

En este caso usamos `actions/hello-world-javascript-action@v1` que está deprecated, de ahí que nos salgan algunos warnings en la ejecución del workflow. 

*Colocamos la ruta del action que queremos ejecutar y despues del @ ponemos la rama, tag o commit que queremos ejecutar, la version (tag)*


## 🚫 06-checkout.yaml

Contiene dos trabajos que realizan el checkout del código del repositorio: uno utilizando la acción checkout y el otro haciendo el checkout de manera manual, mostrando los archivos presentes en el directorio tras cada checkout.


> 1.  `checkout-action` *Hace el checkout por medio de un **Action**.*

> 2.  `checkout-and-display-files` *En este paso el checkout se hace de manera "Manual".*


## 🚫 07-repository-events.yaml

Este archivo configura un workflow que se dispara en respuesta a tres tipos de eventos de GitHub: `push, pull_request, issues`. 

Realiza una acción de checkout y luego lista los archivos en el directorio de trabajo.

> `checkout-test` *Hace el checkout por medio de un **Action**.*


## 🎁 Expresiones de Gratitud
- Comenta a otros sobre este proyecto 📢
- Invita una cerveza 🍺 o un café ☕ a alguien del equipo.
- Da las gracias públicamente 🤓.
- etc.