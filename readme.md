# UDEMY-GITHUB-ACTIONS

Un proyecto práctico de GitHub Actions y Workflows diseñado para explorar y dominar las capacidades de CI/CD (Integración Continua y Despliegue Continuo) utilizando GitHub Actions.

## 🚀 Empezando

Sigue estas instrucciones para configurar y ejecutar el proyecto en tu máquina local para desarrollo y pruebas. 

Consulta la sección de Instalación para detalles sobre cómo configurar el entorno.

## 🔧 Instalación
Las acciones dependen de variables de entorno específicas para un comportamiento adecuado. 

Establece las siguientes variables en las configuraciones de tu repositorio:

`[url-repositorio]/settings/variables/actions/new`

| Name                 | Value | Descripcion |
| -------------------- | ----- |-------------|
| `ACTIONS_RUNNER_DEBUG` | `true` |Activa la información detallada durante la ejecución de los runners.|
| `ACTIONS_STEP_DEBUG`   | `true` |Aumenta la 'verbosity' de los registros para una depuración más detallada de los pasos.|


<br>

# 📦.github/workflows

Encontrarás los workflows en el directorio `.github/workflows`. 

Estos archivos configuran distintos aspectos de GitHub Actions y demuestran su versatilidad.

> [!CAUTION]
> Los workflows están desactivados manualmente. Deberás habilitarlos para ejecutar las pruebas.

<br>

# 00-custom-codeql.yaml ![Static Badge](https://img.shields.io/badge/actions-codeql-red)
Este workflow ejecuta consultas codeQL personalizadas.

<div style="margin-left: 30px;">

### Scripts personalizados
> `qlpack.yml` es el fichero de configuración del pack de queries

> ⚠ No olvides incluir la metadata en los ficheros **ql**.  Code Scanning usa esta información para mostrar los mensajes.

<pre>
📦custom         
 ┣ 📜arraySearch.ql
 ┣ 📜delay.ql
 ┣ 📜example.ql
 ┗ 📜qlpack.yml
</pre>

### Configuración para el workflow
<pre>
📦codeql
 ┗ 📜codeql-config.yml
</pre>

### Workflow
<pre>
📦workflows
 ┣ 📜00-custom-codeql.yml
</pre>
<br>


</div>


## 01-first-workflow.yaml 


Este workflow se ejecuta en dos trabajos paralelos. El primero (run-shell-command) debe completarse antes de que se ejecute el segundo (dependant-job). 

También hay un trabajo paralelo (parallel-job-macos) que se ejecuta en macOS.

<details>

> 1.  `run-shell-command` -> `dependant-job` *(se ejecuta a solo cuando termina run-shell-command)*

> 2.  `parallel-job-macos`

</details>


## 02-workflow-commands.yaml

Este archivo muestra cómo utilizar diferentes comandos para modificar la salida en los registros de ejecución de un workflow, tales como mostrar errores, advertencias, información y agrupar mensajes.

<details>
Ejecuta un único paso en el que se muestran los resultados en diferentes formatos: 

- Error
- Warning
- Notice
- Agrupación de los mensajes

> `testing-wf-commands`

</details>


## 03-working-dir-and-shells.yaml

Establece diferentes directorios de trabajo y shells en una máquina virtual Ubuntu y luego repite un proceso similar en Windows. Se utilizan comandos específicos para cada sistema operativo para mostrar la información del directorio.

<details>

Este workflow muestra dos pasos que se ejecutan en secuencia

> 1.  `display-wd-info` *comandos y variables ubuntu-latest*

> 2.  `display-wd-info-windows` *comandos y variables windows-latest*
</details>

## 04-working-dir-and-using-default-shell.yaml 

Similar al archivo anterior, pero además establece un shell predeterminado para todos los pasos en un entorno Ubuntu y luego para pasos individuales en un entorno Windows, incluyendo la utilización del shell de Python.

<details>
<br>

> 1.  `display-wd-info` *comandos y variables ubuntu-latest*

> 2.  `display-wd-info-windows` *comandos y variables windows-latest / python*

</details>


## 05-simple-action.yaml

Este workflow llama un `Action` entre sus steps, los `Action` ejecutan tareas mas complejas que solo ejecutar un comando como en los ejemplos anteriores.

<details>
<br>

Un `Action` es una unidad de codigo reutilizable que referenciamos en nuestros steps.

En este caso usamos `actions/hello-world-javascript-action@v1` que está deprecated, de ahí que nos salgan algunos warnings en la ejecución del workflow. 

*Colocamos la ruta del action que queremos ejecutar y despues del @ ponemos la rama, tag o commit que queremos ejecutar, la version (tag)*

</details>

## 06-checkout.yaml

Contiene dos trabajos que realizan el checkout del código del repositorio: uno utilizando la acción checkout y el otro haciendo el checkout de manera manual, mostrando los archivos presentes en el directorio tras cada checkout.

<details>
<br>

> 1.  `checkout-action` *Hace el checkout por medio de un **Action**.*

> 2.  `checkout-and-display-files` *En este paso el checkout se hace de manera "Manual".*
</details>


## 07-repository-events.yaml


Este archivo configura un workflow que se dispara en respuesta a tres tipos de eventos de GitHub: `push, pull_request, issues`. 

Realiza una acción de checkout y luego lista los archivos en el directorio de trabajo.
<details>
<br>

> `checkout-test` *Hace el checkout por medio de un **Action**.*
</details>


## 08-events-activity-types.yaml

[Events that triggers workflow](https://docs.github.com/en/actions/using-workflows/events-that-trigger-workflows)

Este workflow se ejecuta en función en caso que se ejecute determinados tipos de **Activity types** 💥

## 09-pull-request-target.yaml

[En lugar de ejecutar el código fusionado del PR, se ejecuta el código de la rama base](https://docs.github.com/en/actions/using-workflows/events-that-trigger-workflows#pull_request_target)

No usa el codigo del PR, por lo tanto, en caso que la PR venga de un fork externo no necesitará aprobación para ejecutarse.

## 10-workflow-runs.yaml

Se ejecuta un workflow dependiendo de la ejecución de otro.

Es útil si queremos separar las acciones en dos workflows, uno para testing y otro para deploy, por ejemplo.

**Se admiten hasta tres niveles de anidación**

## 11-filter-by-branches-tags-paths.yaml

Se dispara si ocurre la acción en determinada rama, tag, ficheros modificados.


## 12-manually-triggering.yaml

Ejecución manual con parametros.

Ejecución por el cli

```bash
gh workflow run 12-manually-triggering.yaml -f stringInput="from gh cli" -f environment="prod" --ref main
```

> **Api REST**: Necesita un fine-grained personal access token

## 13-external-event.yaml

Eventos externos.

>  Por ejemplo:  una aplicación que en base a determinada situación, se dispara el worokflow.

## 14-stale-issues-pr.yaml

Se marca un issue como stale según un cronometro.

> [Crontab.guru](https://crontab.guru/) - The cron schedule expression generator


## 15-expressions-context.yaml

Se usan [expresiones junto con if keys](https://docs.github.com/en/actions/learn-github-actions/expressions#functions) 

## 16-status-check.yaml

Se usa para saber como ha terminado workflow para saber que acción tomar a continuación.

## 17-env-vars.yaml

Acceso a las variables de entorno y las variables de contexto.

- Variables de entorno se evaluan en el runner machine `$GITHUB_REF`

- Variables de contexto se envían ya evaluadas `github.ref `

[Default environment variables](https://docs.github.com/en/actions/learn-github-actions/variables#default-environment-variables)

## 17-vars-secrets.yaml
Las variables pueden ir a diversos niveles:

    - Organization
    - Repository
    - Enviroment

## 18-.yaml

- Descagar la herramienta [GnuPG](https://gnupg.org/download/)





## 🎁 Expresiones de Gratitud
- Comenta a otros sobre este proyecto 📢
- Da las gracias públicamente 🤓.
- etc.