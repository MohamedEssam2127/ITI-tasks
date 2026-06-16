import 'package:flutter/material.dart';


class TaskChecklist extends StatelessWidget {
  const TaskChecklist({
    super.key,
    required this.tasks,
    required this.completedTaskIndexes,
    required this.onTaskChanged,
  });

  final List<String> tasks;
  final Set<int> completedTaskIndexes;
  final void Function(int index, bool? value) onTaskChanged;

  @override
  Widget build(BuildContext context) {
    return Card(
      elevation: 0,
      child: Column(
        children: [
          for (var index = 0; index < tasks.length; index++) ...[
            CheckboxListTile(
              value: completedTaskIndexes.contains(index),
              onChanged: (value) {
                onTaskChanged(index, value);
              },
              title: Text(tasks[index]),
              controlAffinity: ListTileControlAffinity.leading,
            ),
            if (index != tasks.length - 1) const Divider(height: 0),
          ],
        ],
      ),
    );
  }
}