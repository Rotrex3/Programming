hellou
Como se suben cosas a GitHub? Sencillo, aqui tienes la forma de hacerlo.
Despues de haber modificado el proyecto y llegas a una parte que es totalmente funcional y quieres tenerlo como checkpoint en GitHub pues sigue estas instrucciones:
git status #para ver que le falta por actualizar a GitHub
git add . #para agregar todo lo que no esté actualizado en GitHub (lo que está en rojo)
git status #comprueba que esté todo actualizado (si lo está saldrá en verde)
git commit -m "(un comentario sobre que has hecho)" #asi le pones un comentario para saber que hiciste por último o lo que sea sobre ese documento
git push #así lo subes a GitHub