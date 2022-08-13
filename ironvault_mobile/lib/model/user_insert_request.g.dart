// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'user_insert_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

UserInsertRequest _$UserInsertRequestFromJson(Map<String, dynamic> json) =>
    UserInsertRequest()
      ..name = json['name'] as String?
      ..surname = json['surname'] as String?
      ..email = json['email'] as String?
      ..mobile = json['mobile'] as String?
      ..userName = json['userName'] as String?
      ..password = json['password'] as String?
      ..passwordConfirmation = json['passwordConfirmation'] as String?
      ..roleIdList = (json['roleIdList'] as List<dynamic>?)
          ?.map((e) => e as String)
          .toList();

Map<String, dynamic> _$UserInsertRequestToJson(UserInsertRequest instance) =>
    <String, dynamic>{
      'name': instance.name,
      'surname': instance.surname,
      'email': instance.email,
      'mobile': instance.mobile,
      'userName': instance.userName,
      'password': instance.password,
      'passwordConfirmation': instance.passwordConfirmation,
      'roleIdList': instance.roleIdList,
    };
