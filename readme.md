# UDEMY-GITHUB-ACTIONS

Un proyecto práctico de GitHub Actions y Workflows diseñado para explorar y dominar las capacidades de CI/CD (Integración Continua y Despliegue Continuo) utilizando GitHub Actions.

## 🚀 Empezando
Estas instrucciones te ayudarán a configurar tu proyecto y a ejecutarlo en tu máquina local para propósitos de desarrollo y pruebas. Ve a la sección Instalación para saber cómo desplegar el proyecto.

### Prerrequisitos
Qué cosas necesitas para instalar el software y cómo instalarlas.

```
```

### Instalación
Una serie de ejemplos paso a paso que te dicen cómo hacer funcionar un entorno de desarrollo.


## 📁 Estructura del Proyecto



## 🔧 Ejecución de las pruebas

Este proyecto incluye varios archivos de configuración de GitHub Actions que demuestran distintos aspectos y capacidades de las GitHub Actions y Workflows. 

A continuación se detalla la función y características principales de cada archivo YAML proporcionado:

## 1️⃣ 01-first-workflow.yaml
Este workflow muestra dos pasos que se ejecutan en paralelo

> 1.  `run-shell-command` -> `dependant-job` *(se ejecuta a solo cuando termina run-shell-command)*

> 2.  `parallel-job-macos`

## 2️⃣ events.yaml

## 3️⃣ simple-action.yaml

## 4️⃣ workflow-commands.yaml

## 5️⃣ working-dir-and-shells.yaml

## 6️⃣ working-dir-and-using-default-shell.yaml

##  7️⃣ checkout.yaml
Descripción: Configura workflows que se activan en respuesta a eventos específicos del repositorio como push, pull_request, e issues.
Utilidad: Muestra cómo utilizar distintos eventos para activar workflows, lo que es fundamental para automatizar tareas en respuesta a acciones comunes en el desarrollo de software.
first-workflow.yaml
Descripción: Define el primer workflow básico, probablemente introduciendo conceptos esenciales de GitHub Actions, como la especificación de eventos de activación y trabajos.
Utilidad: Sirve como una introducción práctica a la creación de workflows, ideal para quienes están empezando con la automatización de CI/CD.
simple-action.yaml
Descripción: Implementa una acción simple, posiblemente enfocada en una tarea específica dentro del ciclo de CI/CD.
Utilidad: Ejemplifica la creación y configuración de una acción personalizada en GitHub, demostrando cómo pequeños scripts o automatizaciones pueden integrarse en flujos de trabajo más grandes.
workflow-commands.yaml
Descripción: Utiliza comandos específicos de workflows para manipular el flujo de trabajo, como establecer variables de entorno, escribir datos de salida, y más.
Utilidad: Ofrece una visión avanzada sobre cómo los comandos pueden controlar el flujo de trabajo, permitiendo una mayor personalización y flexibilidad en la automatización.
working-dir-and-shells.yaml & working-dir-and-using-default-shell.yaml
Descripción: Estos archivos configuran el directorio de trabajo para los trabajos y ajustan el shell utilizado para ejecutar comandos o scripts.
Utilidad: Destacan la importancia de la configuración del entorno de ejecución, incluyendo la selección del directorio de trabajo y la personalización del shell, para adaptarse a diferentes necesidades de desarrollo.
checkout.yaml
Descripción: Define un workflow que utiliza la acción checkout para clonar el repositorio y trabajar con el código fuente.
Utilidad: Demuestra cómo preparar el entorno de trabajo para los jobs de un workflow, un paso esencial para la mayoría de las tareas de CI/CD que requieren acceso al código del proyecto.
Cada uno de estos archivos configura aspectos específicos de los workflows de GitHub Actions, desde la respuesta a eventos del repositorio hasta la configuración detallada del entorno de ejecución. Son ejemplos prácticos ideales para aquellos que buscan entender y aplicar las GitHub Actions en sus proyectos de desarrollo de software.

## 🛠️ Construido con


## 🎁 Expresiones de Gratitud
- Comenta a otros sobre este proyecto 📢
- Invita una cerveza 🍺 o un café ☕ a alguien del equipo.
- Da las gracias públicamente 🤓.
- etc.