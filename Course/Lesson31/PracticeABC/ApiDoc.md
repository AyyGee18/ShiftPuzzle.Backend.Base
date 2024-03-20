Описание методов в контроллере TaskController
Showall
Метод Showall принимает GET запрос на /tasks/getall и возвращает список всех задач. Возвращает код состояния 200 (OK) при успешном запросе.

Get_task
Метод Get_task принимает GET запрос на /tasks/gettask с параметром id для получения задачи по указанному идентификатору. Возвращает найденную задачу или код состояния 404 (Not Found) в случае, если задача не найдена.

Add
Метод Add принимает POST запрос на /tasks/createtask с телом запроса, содержащим данные о новой задаче. Добавляет новую задачу в список задач. Возвращает код состояния 200 (OK) при успешном добавлении задачи.

Delete
Метод Delete принимает DELETE запрос на /tasks/deletetask с параметром id для удаления задачи по указанному идентификатору. Удаляет задачу из списка задач. Возвращает код состояния 200 (OK) при успешном удалении задачи или код состояния 404 (Not Found) в случае, если задача не найдена.

Complete
Метод Complete принимает GET запрос на /api/tasks/complete c параметром id для завершения задачи. Изменяет поле задачи IsComplete на true если изначально таковым не являлось.Возвращает код состояния 200 (OK) при успешном завершении задачи или код состояния 404 (Not Found) в случае, если задача не найдена.