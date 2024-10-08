TYPE=VIEW
query=select `history`.`person`.`pers_FIO` AS `pers_FIO`,`history`.`chapter`.`chapter_name` AS `chapter_name`,`history`.`topic`.`topic_name` AS `topic_name` from ((((`history`.`topic` join `history`.`chapter` on((`history`.`topic`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`chapter_persons` on((`history`.`chapter_persons`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`person` on((`history`.`chapter_persons`.`id_person` = `history`.`person`.`id_person`))) join `history`.`topic_persons` on(((`history`.`topic_persons`.`id_person` = `history`.`person`.`id_person`) and (`history`.`topic_persons`.`id_topic` = `history`.`topic`.`id_topic`))))
md5=4d093243572e78c7958473fecac89fa5
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-05-10 10:35:49
create-version=1
source=SELECT\n	  person.pers_FIO,\n	  chapter.chapter_name,\n	  topic.topic_name\n	FROM topic\n	  INNER JOIN chapter\n	    ON topic.id_chapter = chapter.id_chapter\n	  INNER JOIN chapter_persons\n	    ON chapter_persons.id_chapter = chapter.id_chapter\n	  INNER JOIN person\n	    ON chapter_persons.id_person = person.id_person\n	  INNER JOIN topic_persons\n	    ON topic_persons.id_person = person.id_person\n	    AND topic_persons.id_topic = topic.id_topic
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`person`.`pers_FIO` AS `pers_FIO`,`history`.`chapter`.`chapter_name` AS `chapter_name`,`history`.`topic`.`topic_name` AS `topic_name` from ((((`history`.`topic` join `history`.`chapter` on((`history`.`topic`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`chapter_persons` on((`history`.`chapter_persons`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`person` on((`history`.`chapter_persons`.`id_person` = `history`.`person`.`id_person`))) join `history`.`topic_persons` on(((`history`.`topic_persons`.`id_person` = `history`.`person`.`id_person`) and (`history`.`topic_persons`.`id_topic` = `history`.`topic`.`id_topic`))))
