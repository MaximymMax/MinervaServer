-- modified insert-example-data

INSERT INTO public."Account_types"(id, type_name)
	VALUES (1, 'student');

INSERT INTO public."Account_types"(id, type_name)
	VALUES (2, 'hire manager');

INSERT INTO public."Account_types"(id, type_name)
	VALUES (3, 'admin');


INSERT INTO public."Accounts"(
	id, user_name, type_id, email, hashed_password, path_to_profile_photo, phone, path_to_resume, last_sign_in_date)
	VALUES (1, 'Antonio_user', 1, 'Antonio_email', 'hashed_1234', 'accounts\Antonio_user\avatar.jpg', '380-55-444-1488', null, '2024.10.11');

INSERT INTO public."Accounts"(
	id, user_name, type_id, email, hashed_password, path_to_profile_photo, phone, path_to_resume, last_sign_in_date)
	VALUES (2, 'Marta_user', 1, 'Marta_email', 'hashed_4321', 'accounts\defalut\default_avatar.jpg', '380-55-444-1488', 'accounts\Marta_user\cat_avatar.jpg', '2024.10.11');

INSERT INTO public."Accounts"(
	id, user_name, type_id, email, hashed_password, path_to_profile_photo, phone, path_to_resume, last_sign_in_date)
	VALUES (3, 'Scott_user', 2, 'Scott_email', 'hashed_4321111', 'accounts\Scott_user\Scott_user.jpg', '020-10-444-1488', 'accounts\Scott_user\cat_avatar.jpg', '2024.10.11');

INSERT INTO public."Accounts"(
	id, user_name, type_id, email, hashed_password, path_to_profile_photo, phone, path_to_resume, last_sign_in_date)
	VALUES (4, 'Admin', 3, 'Admin_email', 'adfafafafasfa', 'accounts\Admin\Admin_avatar.jpg', '110-53-444-1263', 'accounts\Admin\Admin.jpg', '2024.12.12');


INSERT INTO public."Achievements"(
	account_id, total_tests_count, total_exercises_count, total_articles_count)
	VALUES (1, 1, 2, 2);
INSERT INTO public."Achievements"(
	account_id, total_tests_count, total_exercises_count, total_articles_count)
	VALUES (2, 1, 20, 20);
INSERT INTO public."Achievements"(
	account_id, total_tests_count, total_exercises_count, total_articles_count)
	VALUES (3, 3, 1, 2);
INSERT INTO public."Achievements"(
	account_id, total_tests_count, total_exercises_count, total_articles_count)
	VALUES (4, 0, 10, 5);


INSERT INTO public."Article_themes"(
	id, name)
	VALUES (1, 'programmin');

INSERT INTO public."Article_themes"(
	id, name)
	VALUES (2, 'design');

INSERT INTO public."Article_themes"(
	id, name)
	VALUES (3, 'guides');

INSERT INTO public."Article_themes"(
	id, name)
	VALUES (4, 'art');


INSERT INTO public."Articles"(
	id, title, rating, author_id, first_paragraph, path_to_file, theme_id)
	VALUES (1, 'Article 1', 0, 3, 'some text about anything', 'articles\admin.html', 1);


INSERT INTO public."Person"(
	account_id, name, surname, father_name, dob)
	VALUES (1, 'Antonio', 'Smith', 'John', '2000.03.23');

INSERT INTO public."Person"(
	account_id, name, surname, father_name, dob)
	VALUES (2, 'Marta', 'Smith', 'John', '2000.03.23');

INSERT INTO public."Person"(
	account_id, name, surname, father_name, dob)
	VALUES (3, 'Scott', 'Smith', 'John', '2000.03.23');

INSERT INTO public."Person"(
	account_id, name, surname, father_name, dob)
	VALUES (4, 'Admin', 'Smith', 'John', '2000.03.23');


INSERT INTO public."Tests"(
	id, title, rating, author_id, path_to_file)
	VALUES (1, 'first steps in IT', 10, 4, 'tests\4_my_test.json');
	

INSERT INTO public."Vacancy"(
	id, title, path_to_file, hire_manager_id, publish_date, remove_date, views)
	VALUES (1, 'frontend_developer', 'user_files\vacancies\1\Marta_user_frontend_developer.doc', 2, '2025.01.10', '2025.02.10', 0);

INSERT INTO public."Vacancy"(
	id, title, path_to_file, hire_manager_id, publish_date, remove_date, views)
	VALUES (2, 'db_engineer', 'user_files\vacancies\1\Marta_user_db_engineer.doc', 2, '2025.01.10', '2025.02.10', 0);

INSERT INTO public."Vacancy"(
	id, title, path_to_file, hire_manager_id, publish_date, remove_date, views)
	VALUES (3, 'Teacher', 'user_files\vacancies\1\Marta_user_Teacher.doc', 2, '2025.01.10', '2025.02.10', 0);	