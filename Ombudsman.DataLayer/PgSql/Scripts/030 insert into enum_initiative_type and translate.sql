INSERT INTO enum_initiative_type
VALUES 
    (1, 'Вазирлик','Вазирлик'),(2,'Ходим','Ходим'),(3,'Расман киритилган','Расман киритилган');

INSERT INTO enum_initiative_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (1, 1, 'full_name', 'Вазирлик'),
  -- Uzbek Latin translations
  (1, 2, 'full_name', 'Vazirlik'),
  -- Russian translations
  (1, 3, 'full_name', 'Mинистерство'); 

INSERT INTO enum_initiative_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (2, 1, 'full_name', 'Ходим'),
  -- Uzbek Latin translations
  (2, 2, 'full_name', 'Xodim'),
  -- Russian translations
  (2, 3, 'full_name', 'Сотрудник');


INSERT INTO enum_initiative_type_translate (owner_id, language_id, column_name, translate_text)
VALUES
  -- Uzbek Cyrillic translations
  (3, 1, 'full_name', 'Расман киритилган'),
  -- Uzbek Latin translations
  (3, 2, 'full_name', 'Rasman Kiritilgan'),
  -- Russian translations
  (3, 3, 'full_name', 'Официально включен');
