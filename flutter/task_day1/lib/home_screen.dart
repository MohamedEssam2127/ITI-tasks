import 'package:flutter/material.dart';
import 'package:task_day1/Task_check_list.dart';
import 'package:task_day1/name_Card.dart';
import 'header_card.dart';
import 'badge_list.dart';
import 'main_card.dart';
import 'critical_directives_section.dart';
import 'start_lesson_button.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {
  final TextEditingController _UserNameController = TextEditingController();
  final FocusNode _UserNameFocusNode = FocusNode();
  String _UserName = "User";
  List<String> _tasks = ["task1", "task2", "task3", "task4"];
  Set<int> _completedTaskIndexes = {};

 

  void _clearNameInput() {
    _UserNameController.clear();
  }

  void _updateStudentNamePreview() {
    final typedName = _UserNameController.text.trim();

    setState(() {
      if (typedName.isEmpty) {
        _UserName = "User";
      } else {
        _UserName = typedName;
      }
    });
  }

  void _toggleTask(int index, bool? value) {
    setState(() {
      if (_completedTaskIndexes.contains(index)) {
        _completedTaskIndexes.remove(index);
      } else {
        _completedTaskIndexes.add(index);
      }
    });
  }

  int get _completedTaskCount {
    return _completedTaskIndexes.length;
  }

  double get _progressValue {
    return _completedTaskCount / _tasks.length;
  }

  @override
  void initState() {
    super.initState();

    _UserNameController.addListener(_updateStudentNamePreview);
  }

  @override
  void dispose() {
    _UserNameController.removeListener(_updateStudentNamePreview);
    _UserNameController.dispose();
    _UserNameFocusNode.dispose();
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    final colorScheme = Theme.of(context).colorScheme;
    return Scaffold(
      backgroundColor: colorScheme.surface,
      appBar: AppBar(
        title: const Text(
          "Task Analytics Workspace",
          style: TextStyle(fontWeight: FontWeight.bold, fontSize: 22),
        ),
        centerTitle: true,
      ),
      body: SafeArea(
        child: SingleChildScrollView(
          padding: EdgeInsets.symmetric(horizontal: 18, vertical: 16),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              HeaderCard(text: _UserName),
              SizedBox(height: 24),
              BadgeList(),
              NameCard(
                controller: _UserNameController,
                focusNode: _UserNameFocusNode,
                clear: _clearNameInput,
              ),
              SizedBox(height: 24),
              MainCard(
                totalTasks: _tasks.length,
                completedTasks: _completedTaskCount,
                ratio: _progressValue,
              ),
              SizedBox(height: 24),
              TaskChecklist(
                tasks: _tasks,
                completedTaskIndexes: _completedTaskIndexes,
                onTaskChanged: _toggleTask,
              ),
              //   CriticalDirectivesSection(),
              //  StartLessonButton()
            ],
          ),
        ),
      ),
    );
  }
}
