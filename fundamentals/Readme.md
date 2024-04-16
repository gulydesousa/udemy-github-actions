# GIT

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

Existen tres tipos de clonning: 


```sh
git clone https://github.com/seawaving/udemy-github-actions.git
```

### HTTP
> Venimos de clonar por **HTTP**

```sh
git clone https://github.com/seawaving/udemy-github-actions.git
```

Este tipo de autenticación requiere un token.

Creamos el Personal Access Token desde `(user)/settings/<Developer Settings>/Personal Access Tokens/Fine-grained tokens`

Asignamos solo los permisos necesarios
- **Commit statuses** (Read-Write)
- **Contents** (Read-Write)

Generamos y copiamos el token, es ese valor el que usaremos para hacer push cuando nos pida un password.

### SSH
> Venimos de clonar con **SSH**
> Los comandos los ejecutamos con el **gh bash**

Si el repositorio es privado, la credencial debería estar ya seteada para poder bajar el repositorio.
Este es publico, por lo que la credencial la vamos a necesitar para hacer push solamente.

```sh
git clone git@github.com:gulydesousa/udemy-github-actions.git
```

Esta autenticacion requiere una clave **SSH** que vamos a generar

> Dejaremos el SSH en la ruta `C:\Users\guly.desousa\.ssh`

```sh
ssh-keygen -t rsa 

Enter file in which to save the key (/c/Users/guly.desousa/.ssh/id_rsa): /c/users/guly.desousa/.ssh/alt-github_id_rsa

# Copiamos la clave publica en el github
cat /c/users/guly.desousa/.ssh/alt-github_id_rsa.pub

```
Creamos la SSH desde `(user)/settings/SSH and GPG keys`

![alt text](images/ssh.png)

Comprobar que tenemos acceso por **SSH**
```sh
ssh -T git@github.com

# Arrancamos el agente ssh
eval $(ssh-agent -s)

# Agregamos la clave privada
ssh-add /c/users/guly.desousa/.ssh/alt-github_id_rsa
```

Ya nos deja hacer el push


### Otra forma de usar ssh-keygen

```sh
ssh-keygen -t ed25519
cat /c/Users/guly.desousa/.ssh/id_ed25519.pub
```

Este comando nos deja el archivo directamente en el directorio `.ssh`

> `Your identification has been saved in /c/Users/guly.desousa/.ssh/id_ed25519`

### SSH desde el CLI

Nos guia paso a paso para crear el SSH y nos crea el SSH el nuestra cuenta.


```ssh
gh auth login
```

![alt text](images/sshCLI.png)



### GitHub CLI

- Instalar el CLI. 
En el caso de windows lo he hecho con el ejecutable que me bajé de GitHub

```sh
 gh --version

gh repo clone gulydesousa/udemy-github-actions /c/Gdesousa/github/udemy-github-actions

```

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


## Push

Para subir los cambios al repositorio remoto de origen

```sh
git push
```

## Branches

```sh
#Para listar las ramas
git branch

#Para crear una rama
git branch develop

#Para subir la rama al repositorio remoto
git push --set-upstream origin develop
```


```sh
 # Para crear una nueva rama
 git branch my-new-branch
 git chechout my-new-branch

 #Se puede hacer lo mismo en una sola linea
git chechout -b my-new-branch
```

### Checkout branch

Hacer "checkout" a una rama en Git significa cambiar desde la rama actual a otra rama. 

Cuando haces checkout a una nueva rama, tu directorio de trabajo se actualiza para reflejar el contenido de la nueva rama, tus archivos se actualizan para coincidir con las versiones presentes en la rama y Git comienza a registrar tus nuevos commits en esa rama.


```sh
#Para cambiarnos de rama
git checkout develop
```

## Fetch
El comando `git fetch` en Git se utiliza para descargar todos los cambios recientes en el repositorio remoto que aún no están presentes en tu repositorio local. No fusiona automáticamente estos cambios en tu rama actual ni modifica tus archivos de trabajo. Solo trae las actualizaciones a tu repositorio local para que puedas revisarlas y decidir si quieres integrarlas en tu trabajo actual.


```sh
#Actualizar la rama con lo que hay en el repo 
git fetch
```

## Remotes


## Stashes

El comando git stash en Git se utiliza para guardar temporalmente cambios que has hecho pero que no quieres commit aún, de modo que puedas cambiar a otra rama. 

Los cambios que guardas con git stash se pueden aplicar más tarde cuando estés listo.


```sh
# Ver los cambios guardados
git stash list
# Guardar tus cambios
git stash
# Guardar tus cambios con un nombre
git stash save my-name
# Aplica los ultimos cambios
git stash apply
#Aplica los cambios guardados más recientemente con git stash y luego los elimina de tu lista de cambios guardados
git stash pop
```

## Merging

```sh
#Nos pasamos a la rama develop
git checkout develop

# Intentará fusionar los cambios de la rama main en tu rama develop
git merge main
```


## Tags

Muchos usan los tags para disparar la integración a producción

```sh
# Description: Creates a lightweight tag named "1.0.0" at the current commit.
# Documentation: https://git-scm.com/docs/git-tag
git tag 1.0.0

# Description: Pushes all tags to the remote repository.
# Documentation: https://git-scm.com/docs/git-push
git push  --tags

# Description: Switches to the commit associated with the tag "1.0.0".
# Documentation: https://git-scm.com/docs/git-checkout
git checkout 1.0.0

# Description: Deletes the local tag "1.0.0".
# Documentation: https://git-scm.com/docs/git-tag
git tag -d 1.0.0

# Description: Deletes the remote tag "1.0.0".
# Documentation: https://git-scm.com/docs/git-push
git push  -- delete origin 1.0.0
```

<br>


# GITHUB CLI


## gh repo list

```sh
Showing 23 of 23 repositories in @gulydesousa

NAME                              DESCRIPTION                  INFO     UPDATED
gulydesousa/udemy-github-actions                               public   about 48 minutes ago
gulydesousa/sql-sprints           backup de los scripts        private  about 2 hours ago
gulydesousa/angular                                            public   about 1 day ago
gulydesousa/github-bootcamp       Practicas                    private  about 4 days ago
gulydesousa/csharp                                             public   about 8 days ago
gulydesousa/test-codeql                                        public   about 9 days ago
gulydesousa/ceFacturas                                         public   about 14 days ago
gulydesousa/netcore               Proyectos de NetCore         public   about 16 days ago
gulydesousa/python                Proyectos de python          private  about 29 days ago
gulydesousa/DependencyInjection                                private  about 2 months ago
gulydesousa/sprints-acuama                                     public   about 3 months ago
gulydesousa/DapperDemo                                         private  about 3 months ago
gulydesousa/aspnetcore            Curso Net Core               private  about 3 months ago
gulydesousa/cs12dotnet8                                        private  about 4 months ago
gulydesousa/Chapter01                                          private  about 4 months ago
gulydesousa/pipes-app                                          private  about 4 months ago
gulydesousa/gifs-app                                           public   about 5 months ago
gulydesousa/graficos              Chart.js                     private  about 8 months ago
gulydesousa/fotos-firebase                                     private  about 8 months ago
gulydesousa/angular-youtube       Proyecto con api youtube     public   about 8 months ago
gulydesousa/peliculas                                          private  about 8 months ago
gulydesousa/docs                  Documentos                   private  about 8 months ago
gulydesousa/angular-13-firechat   Angular desde cero Firebase  public   about 8 months ago

```


## gh repo set-default

```sh
$ gh repo set-default
Found only one known remote repo, gulydesousa/udemy-github-actions on github.com.
✓ Set gulydesousa/udemy-github-actions as the default repository for the current directory
```


## gh label list

```sh
Showing 9 of 9 labels in gulydesousa/udemy-github-actions

NAME              DESCRIPTION                                 COLOR  
bug               Something isn't working                     #d73a4a
documentation     Improvements or additions to documentation  #0075ca
duplicate         This issue or pull request already exists   #cfd3d7
enhancement       New feature or request                      #a2eeef
good first issue  Good for newcomers                          #7057ff
help wanted       Extra attention is needed                   #008672
invalid           This doesn't seem right                     #e4e669
question          Further information is requested            #d876e3
wontfix           This will not be worked on                  #ffffff
```

```sh
gh label create soporte --description "peticiones de los usuarios que no implican cambios en el codigo"  --color ffa500
```

## gh repo create

```sh
guly.desousa@GULYDESOUSA MINGW64 /c/Gdesousa/github/udemy-github-actions (main)
$ gh repo create
? What would you like to do? Create a new repository on GitHub from scratch
? Repository name cli-example

? Repository name cli-example
? Repository owner gulydesousa
? Description test

? Description test
? Visibility Public
? Would you like to add a README file? No
? Would you like to add a .gitignore? No
? Would you like to add a license? No
? This will create "cli-example" as a public repository on GitHub. Continue? Yes
✓ Created repository gulydesousa/cli-example on GitHub
? Clone the new repository locally? No      
? Clone the new repository locally? (Y/n) n
```
