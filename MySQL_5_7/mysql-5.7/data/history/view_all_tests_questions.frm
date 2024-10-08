TYPE=VIEW
query=select `history`.`tests`.`test_name` AS `test_name`,`history`.`questions`.`quest_text` AS `quest_text` from `history`.`questions` join `history`.`tests`
md5=c15ccdf5d02bab6010f35262d96267bf
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-05-05 11:31:06
create-version=1
source=SELECT\n	  tests.test_name,\n	  questions.quest_text\n	FROM questions,\n	     tests
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`tests`.`test_name` AS `test_name`,`history`.`questions`.`quest_text` AS `quest_text` from `history`.`questions` join `history`.`tests`
