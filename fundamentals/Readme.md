## .git *-hidden folder-*

Directorio oculto que nos dice que nuestra carpeta es un repositorio.

Con el `VS Code` podemos explorarla si cambiamos la configuración que nos oculta el directorio.

La opción la puedes encontrar desde **Settings** y buscando *files Exclude*

Para crear un nuevo repositorio en un nuevo proyecto se inicializa el repo con `git init`

```sh
git init
```

## gitconfig *file*

Archivo donde se guardan las configuraciones globales para git, como usuario, mail, editor entre otros

```sh
git config --list
```

Cuando instalar el git debes inicializar los valores de nombre e emal.

```sh
git config --global user.name "Guly de Sousa"
git config --global user.email "gdesousa@gmail.com"
```


## Clonning

Existen tres tipos de clonning: **HTTPS, SSH, Github CLI**


```sh
git clone https://github.com/seawaving/udemy-github-actions.git
```

### HTTP



### SSH


### GitHub CLI







### Clonning en el codespace

Creamos un directorio temporal en el `workspace`

```sh
mkdir /workspace/tmp
cd /workspace/tmp
git clone https://github.com/seawaving/udemy-github-actions.git
#Para ver los archiivos en el directorio
ls -la
#Inicializamos el repositorio
git init
#Hacemos el cambio para el readme file
touch Readme.md
open Readme.md
#Hacer cambios en el readme.md y ver los cambios pendientes
git status
# Agregamos todos los cambios al commit
git add .
# Deshacemos el add con reset
git reset
# Agregamos solo el readme.md
git add Readme.md
git commit -a -m "add readme file"
```

## Add

Para hacer stage de todos los cambios o de un archivo en particular.

```sh
git add  Readme.md
git add .
```

## Reset

Esta opcion nos permite mover los cambios staged a unstaged.
Esto nos permite revertir todos los cambios.

```sh
git add .
git reset
```
> `git reset` revierte un `git add .`


## Status

Muesta los archivos que se va a hacer commit, así como los que quedarían por fuera.

```sh
git status
```

## Commits

Cuando queremos hacer commit nos abrirá una ventana de edición del commit para poner un mensaje .

```sh
git commit
```

Se puede configurar el editor global

```sh
git config --global core.editor emacs
```

Commit sin abrir el editor

```sh
git commit -m "informacion del cambio"
```

## Log

`git log` muestra información de los logs recientes


# Push

Para subir los cambios al repositorio remoto de origen

```sh
git push
```

## Branches

## Remotes


## Stashes

## Merging