TYPE=VIEW
query=select `history`.`chapter`.`id_chapter` AS `id_chapter`,`history`.`chapter`.`chapter_name` AS `chapter_name`,`history`.`topic`.`id_topic` AS `id_topic`,`history`.`topic`.`topic_name` AS `topic_name`,`history`.`topic`.`topic_desc` AS `topic_desc`,`history`.`gallery`.`pic_name` AS `pic_name`,`history`.`gallery`.`picture` AS `picture` from ((`history`.`topic` join `history`.`chapter` on((`history`.`topic`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`gallery` on((`history`.`topic`.`id_picture` = `history`.`gallery`.`id_picture`)))
md5=7eb392db1762fcc9a02a982aeadbf0b4
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-04-22 08:48:58
create-version=1
source=SELECT\n	  chapter.id_chapter AS id_chapter,\n	  chapter.chapter_name AS chapter_name,\n	  topic.id_topic AS id_topic,\n	  topic.topic_name AS topic_name,\n	  topic.topic_desc AS topic_desc,\n	  gallery.pic_name,\n	  gallery.picture\n	FROM topic\n	  INNER JOIN chapter\n	    ON topic.id_chapter = chapter.id_chapter\n	  INNER JOIN gallery\n	    ON topic.id_picture = gallery.id_picture
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`chapter`.`id_chapter` AS `id_chapter`,`history`.`chapter`.`chapter_name` AS `chapter_name`,`history`.`topic`.`id_topic` AS `id_topic`,`history`.`topic`.`topic_name` AS `topic_name`,`history`.`topic`.`topic_desc` AS `topic_desc`,`history`.`gallery`.`pic_name` AS `pic_name`,`history`.`gallery`.`picture` AS `picture` from ((`history`.`topic` join `history`.`chapter` on((`history`.`topic`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`gallery` on((`history`.`topic`.`id_picture` = `history`.`gallery`.`id_picture`)))
