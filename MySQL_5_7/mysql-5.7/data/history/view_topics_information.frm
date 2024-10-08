TYPE=VIEW
query=select `history`.`topic`.`topic_name` AS `topic_name`,`history`.`topicinfo`.`topinfo_name` AS `topinfo_name`,`history`.`topicinfo`.`topinfo_text` AS `topinfo_text` from (`history`.`topicinfo` join `history`.`topic` on((`history`.`topicinfo`.`id_topic` = `history`.`topic`.`id_topic`)))
md5=710aeb4447f3bb1fee8961697a722fb7
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-05-05 11:05:42
create-version=1
source=SELECT\n	  `topic`.`topic_name` AS `topic_name`,\n	  `topicinfo`.`topinfo_name` AS `topinfo_name`,\n	  `topicinfo`.`topinfo_text` AS `topinfo_text`\n	FROM (`topicinfo`\n	  JOIN `topic`\n	    ON ((`topicinfo`.`id_topic` = `topic`.`id_topic`)))
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`topic`.`topic_name` AS `topic_name`,`history`.`topicinfo`.`topinfo_name` AS `topinfo_name`,`history`.`topicinfo`.`topinfo_text` AS `topinfo_text` from (`history`.`topicinfo` join `history`.`topic` on((`history`.`topicinfo`.`id_topic` = `history`.`topic`.`id_topic`)))
