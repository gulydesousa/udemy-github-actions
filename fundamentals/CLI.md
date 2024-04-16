# GitHub CLI

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