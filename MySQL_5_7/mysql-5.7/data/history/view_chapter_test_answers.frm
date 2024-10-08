TYPE=VIEW
query=select `history`.`chapter`.`chapter_name` AS `chapter_name`,`history`.`tests`.`test_name` AS `test_name`,`history`.`questions`.`quest_text` AS `quest_text`,`history`.`answers`.`answ_text` AS `answ_text`,`history`.`answers`.`answ_corr` AS `answ_corr` from (`history`.`answers` join `history`.`questions` on((`history`.`answers`.`id_question` = `history`.`questions`.`id_question`))) join ((`history`.`tests_chapter` join `history`.`chapter` on((`history`.`tests_chapter`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`tests` on((`history`.`tests_chapter`.`id_test` = `history`.`tests`.`id_test`))) where (`history`.`answers`.`answ_corr` = 1)
md5=1db05dae8579956982f58c87fffa87a3
updatable=1
algorithm=0
definer_user=root
definer_host=localhost
suid=2
with_check_option=0
timestamp=2024-05-05 11:09:07
create-version=1
source=SELECT\n	  chapter.chapter_name,\n	  tests.test_name,\n	  questions.quest_text,\n	  answers.answ_text,\n	  answers.answ_corr\n	FROM answers\n	       INNER JOIN questions\n	         ON answers.id_question = questions.id_question,\n	     tests_chapter\n	       INNER JOIN chapter\n	         ON tests_chapter.id_chapter = chapter.id_chapter\n	       INNER JOIN tests\n	         ON tests_chapter.id_test = tests.id_test\n	WHERE answers.answ_corr = 1
client_cs_name=utf8
connection_cl_name=utf8_general_ci
view_body_utf8=select `history`.`chapter`.`chapter_name` AS `chapter_name`,`history`.`tests`.`test_name` AS `test_name`,`history`.`questions`.`quest_text` AS `quest_text`,`history`.`answers`.`answ_text` AS `answ_text`,`history`.`answers`.`answ_corr` AS `answ_corr` from (`history`.`answers` join `history`.`questions` on((`history`.`answers`.`id_question` = `history`.`questions`.`id_question`))) join ((`history`.`tests_chapter` join `history`.`chapter` on((`history`.`tests_chapter`.`id_chapter` = `history`.`chapter`.`id_chapter`))) join `history`.`tests` on((`history`.`tests_chapter`.`id_test` = `history`.`tests`.`id_test`))) where (`history`.`answers`.`answ_corr` = 1)
